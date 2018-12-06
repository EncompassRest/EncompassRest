namespace EncompassRest.Services.Appraisal
{
    /// <summary>
    /// The parameters to specify when ordering an appraisal.
    /// </summary>
    public sealed class OrderAppraisalParameters : OrderServiceParameters
    {
        /// <summary>
        /// Object containing all the necessary product information needed for an appraisal service provider to process a service request.
        /// </summary>
        public new AppraisalProduct Product => (AppraisalProduct)base.Product;

        /// <summary>
        /// OrderAppraisalParameters constructor.
        /// </summary>
        /// <param name="product">Object containing all the necessary product information needed for an appraisal service provider to process a service request.</param>
        public OrderAppraisalParameters(AppraisalProduct product)
            : base(product)
        {
        }
    }
}