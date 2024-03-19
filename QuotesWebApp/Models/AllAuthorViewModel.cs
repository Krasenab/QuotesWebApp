namespace QuotesWebApp.Models
{
    public class AllAuthorViewModel
    {
        public AllAuthorViewModel()
        {
            this.EachRetings = new List<EachRetingViewModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public string Category { get; set; }

        public string YearsFromTo { get; set; }

        public double RatingResult { get; set; }

        List<EachRetingViewModel> EachRetings { get; set; }
    }
}
