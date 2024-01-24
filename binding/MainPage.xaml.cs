
namespace binding
{
    public partial class MainPage : ContentPage
    {
        public Student s {  get; set; }
   

        public MainPage()
        {
            InitializeComponent();
            s = new Student() { Name = "Shahar", Age = 17 };
            this.BindingContext = s;
        }
        private void changeName(object sender, EventArgs e)
        {
            s.Name = "NotShahar";
        }

     
    }
}