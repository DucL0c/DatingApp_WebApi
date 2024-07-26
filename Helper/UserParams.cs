namespace api.Helper
{
    public class UserParams : PaginationParams
    {
        private string _gender = "male";
        private int _minAge = 18;
        private int _maxAge = 99;
        public string? CurrentUsername { get; set; }
        public string? Gender
        {
            get => _gender;
            set => _gender = value;
        }
        public int MinAge { get => _minAge; set => _minAge = value; }
        public int MaxAge { get => _maxAge; set => _maxAge = value; }

        public string OrderBy { get; set; } = "lastActive";
    }
}
    