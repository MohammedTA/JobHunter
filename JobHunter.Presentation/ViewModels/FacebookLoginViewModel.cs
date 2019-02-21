namespace JobHunter.Presentation.ViewModels
{
    public class FacebookLoginViewModel
    {
        public string authToken { get; set; }
        public string email { get; set; }
        public FacebookDetail facebook { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public string photoUrl { get; set; }
        public string provider { get; set; }
    }

    public class FacebookDetail
    {
        public string email { get; set; }
        public string first_name { get; set; }
        public string id { get; set; }
        public string last_name { get; set; }
        public string name { get; set; }
    }
}