using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.v1;

internal sealed class FieldDescriptors : IDictionary<string, FieldDescriptor>, IReadOnlyDictionary<string, FieldDescriptor>
{
    private readonly ConcurrentDictionary<string, FieldDescriptorBase> _fieldMappingsCollection;
    private readonly LoanFieldPatternMappingsBase.LoanFieldPatternMappingsCollection _fieldPatternMappingsCollection;

    public int Count => _fieldMappingsCollection.Count + _fieldPatternMappingsCollection.Count;

    public FieldDescriptor this[string fieldId]
    {
        get
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            if (!_fieldMappingsCollection.TryGetValue(fieldId, out var descriptor) && !_fieldPatternMappingsCollection.TryGetDescriptorForFieldId(fieldId, out descriptor!))
            {
                throw new ArgumentException($"Could not find field '{fieldId}'");
            }
            return (FieldDescriptor)descriptor;
        }
    }

    public ICollection<string> Keys => _fieldMappingsCollection.Keys.Concat(_fieldPatternMappingsCollection.FieldPatterns).ToList();

    public ICollection<FieldDescriptor> Values => _fieldMappingsCollection.Values.Concat(_fieldPatternMappingsCollection.Descriptors).Cast<FieldDescriptor>().ToList();

    IEnumerable<string> IReadOnlyDictionary<string, FieldDescriptor>.Keys => Keys;

    IEnumerable<FieldDescriptor> IReadOnlyDictionary<string, FieldDescriptor>.Values => Values;

    bool ICollection<KeyValuePair<string, FieldDescriptor>>.IsReadOnly => true;

    FieldDescriptor IDictionary<string, FieldDescriptor>.this[string key] { get => this[key]; set => throw new NotSupportedException(); }

    internal FieldDescriptors(ConcurrentDictionary<string, FieldDescriptorBase> fieldMappingsCollection, LoanFieldPatternMappingsBase.LoanFieldPatternMappingsCollection fieldPatternMappingsCollection)
    {
        _fieldMappingsCollection = fieldMappingsCollection;
        _fieldPatternMappingsCollection = fieldPatternMappingsCollection;
    }

    public bool ContainsKey(string fieldId) => TryGetValue(fieldId, out _);

    public bool TryGetValue(string fieldId, out FieldDescriptor descriptor)
    {
        Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

        var success = _fieldMappingsCollection.TryGetValue(fieldId, out var d) || _fieldPatternMappingsCollection.TryGetDescriptorForFieldId(fieldId, out d!);
        descriptor = (FieldDescriptor)d;
        return success;
    }

    public IEnumerator<KeyValuePair<string, FieldDescriptor>> GetEnumerator()
    {
        foreach (var pair in _fieldMappingsCollection)
        {
            yield return KeyValuePair.Create(pair.Key, (FieldDescriptor)pair.Value);
        }

        foreach (var pair in _fieldPatternMappingsCollection)
        {
            yield return KeyValuePair.Create(pair.Key, (FieldDescriptor)pair.Value);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    void IDictionary<string, FieldDescriptor>.Add(string key, FieldDescriptor value) => throw new NotSupportedException();

    bool IDictionary<string, FieldDescriptor>.Remove(string key) => throw new NotSupportedException();

    void ICollection<KeyValuePair<string, FieldDescriptor>>.Add(KeyValuePair<string, FieldDescriptor> item) => throw new NotSupportedException();

    void ICollection<KeyValuePair<string, FieldDescriptor>>.Clear() => throw new NotSupportedException();

    bool ICollection<KeyValuePair<string, FieldDescriptor>>.Contains(KeyValuePair<string, FieldDescriptor> item) => TryGetValue(item.Key, out var descriptor) && descriptor == item.Value;

    void ICollection<KeyValuePair<string, FieldDescriptor>>.CopyTo(KeyValuePair<string, FieldDescriptor>[] array, int arrayIndex) => this.ToList().CopyTo(array, arrayIndex);

    bool ICollection<KeyValuePair<string, FieldDescriptor>>.Remove(KeyValuePair<string, FieldDescriptor> item) => throw new NotSupportedException();
}
