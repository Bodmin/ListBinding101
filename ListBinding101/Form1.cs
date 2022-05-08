namespace ListBinding101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var people = new List<Person>();
            people.Add(new Person() { personId = 1, personName = "Fred", personLName="Flintstone" });
            people.Add(new Person() { personId = 2, personName = "Stan", personLName = "Stringle" });
            people.Add(new Person() { personId = 3, personName = "Mary", personLName = "Heyline" });
            people.Add(new Person() { personId = 4, personName = "Helen", personLName = "Glendine" });

            comboBoxPeople.DataSource = people;
            comboBoxPeople.DisplayMember = "fullName";
            comboBoxPeople.ValueMember = "personId";
            listBoxPerson.DataSource = people;
            listBoxPerson.DisplayMember = "fullName";
        }

        private void comboBoxPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPerson = (Person)comboBoxPeople.SelectedItem as Person;
           txtName.Text = selectedPerson.fullName.ToString();
        }
                
    }

    public class Person
    {
        public int personId { get; set; }
        public string? personName { get; set; }
        public string? personLName { get; set; }

        public string fullName
        {
            get {
                return personName + " " + personLName;
            }
        }


    }
}