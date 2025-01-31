namespace Kodigos.Services {

    /// <summary>
    /// Service for value analysis operations
    /// </summary>
    public class ValueAnalysisService {

       
        /// <summary>
        /// Gets a mock ValueAnalysis object.
        /// </summary>
        /// <returns>A mock ValueAnalysis object.</returns>
        public ValueAnalysis GetMock() {
            return new ValueAnalysis {
                Id = 1,
                products = new ProductService().GetSomeMock(),
                suppliers = new SupplierService().GetSomeMock(),
                status = Status.Pending
            };
        }
    }
}