namespace ActiveXLib_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(new ActiveXLib.ControlloActiveX());
        }
    }
}