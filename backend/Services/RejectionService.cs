namespace Kodigos.Services {
public class RejectionService {
    public List<Rejection> GetSomeMock() {
        return new List<Rejection> {
            new Rejection { id = 1, valueAnalysisId = 1, reason = "Reason 1" },
            new Rejection { id = 2, valueAnalysisId = 2, reason = "Reason 1" },
        };
    }

    public Rejection Create(Rejection r) {
        return r;
    }
}
}