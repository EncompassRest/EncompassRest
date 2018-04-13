namespace EncompassRest.Services.Appraisal
{
    public sealed class OrderAppraisalParameters : OrderServiceParameters
    {
        public new AppraisalProduct Product => (AppraisalProduct)base.Product;

        public OrderAppraisalParameters(AppraisalProduct product)
            : base(product)
        {
        }
    }
}