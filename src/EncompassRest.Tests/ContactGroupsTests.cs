using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Contacts;
using EnumsNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class ContactGroupsTests : TestBaseClass
    {
        [TestMethod]
        public async Task ContactGroups_CreateUpdateAndDelete()
        {
            var client = await GetTestClientAsync();
            var contactGroups = client.ContactGroups;
            foreach (var contactType in Enums.GetValues<ContactType>())
            {
                var groupType = contactType == ContactType.Business ? ContactGroupType.Public : ContactGroupType.Private;
                var groupAdded = new ContactGroup("ABC", contactType, groupType);
                var groupId = await contactGroups.CreateGroupAsync(groupAdded, true);
                try
                {
                    Assert.AreEqual(groupId, groupAdded.Id);
                    Assert.IsNotNull(groupAdded.CreatedDate);
                    var groups = await contactGroups.GetGroupsAsync(contactType, groupType);
                    Assert.IsNotNull(groups);
                    Assert.IsTrue(groups.Count > 0);
                    var foundGroup = groups.FirstOrDefault(g => g.Id == groupId);
                    Assert.IsNotNull(foundGroup);
                    Assert.AreEqual(groupAdded.ContactType.Value, foundGroup.ContactType.Value);
                    Assert.AreEqual(groupAdded.Name, foundGroup.Name);
                    Assert.AreEqual(groupAdded.GroupType.Value, foundGroup.GroupType.Value);
                    var retrievedGroup = await contactGroups.GetGroupAsync(groupId);
                    Assert.IsNotNull(retrievedGroup);
                    Assert.AreEqual(groupAdded.ContactType.Value, retrievedGroup.ContactType.Value);
                    Assert.AreEqual(groupAdded.Name, retrievedGroup.Name);
                    Assert.AreEqual(groupAdded.GroupType.Value, retrievedGroup.GroupType.Value);

                    groupAdded = new ContactGroup(groupId, "DEF", contactType, groupType);
                    await contactGroups.UpdateGroupAsync(groupAdded);
                    retrievedGroup = await contactGroups.GetGroupAsync(groupId);
                    Assert.IsNotNull(retrievedGroup);
                    Assert.AreEqual(groupAdded.ContactType.Value, retrievedGroup.ContactType.Value);
                    Assert.AreEqual(groupAdded.Name, retrievedGroup.Name);
                    Assert.AreEqual(groupAdded.GroupType.Value, retrievedGroup.GroupType.Value);
                }
                finally
                {
                    await contactGroups.DeleteGroupAsync(groupId);
                }
            }
        }
    }
}