namespace DesignPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FactoryPatternShapeFactory shapeFactory = new FactoryPatternShapeFactory();

            // ���Circle����ýեΨ�draw��k�C
            FactoryPatternShape shape1 = shapeFactory.GetShape("FactoryPatternCircle");

            // �ե�Circle��draw��k�æbMessageBox����ܵ��G�C
            MessageBox.Show(shape1.Draw());

            // ���Rectangle����ýեΨ�draw��k�C
            FactoryPatternShape shape2 = shapeFactory.GetShape("FactoryPatternRectangle");

            // �ե�Rectangle��draw��k�æbMessageBox����ܵ��G�C
            MessageBox.Show(shape2.Draw());

            // ���Square����ýեΨ�draw��k�C
            FactoryPatternShape shape3 = shapeFactory.GetShape("FactoryPatternSquare");

            // �ե�Square��draw��k�æbMessageBox����ܵ��G�C
            MessageBox.Show(shape3.Draw());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //����Ϊ��u�t
            AbstractFactoryPatternAbstractFactory shapeFactory = AbstractFactoryPatternFactoryProducer.GetFactory("SHAPE");

            //����Ϊ��� Circle ����H
            AbstractFactoryPatternShape shape1 = shapeFactory.GetShape("CIRCLE");

            //�ե� Circle �� Draw ��k
            MessageBox.Show(shape1.Draw());

            //����Ϊ��� Rectangle ����H
            AbstractFactoryPatternShape shape2 = shapeFactory.GetShape("RECTANGLE");

            //�ե� Rectangle �� Draw ��k
            MessageBox.Show(shape2.Draw());

            //����Ϊ��� Square ����H
            AbstractFactoryPatternShape shape3 = shapeFactory.GetShape("SQUARE");

            //�ե� Square �� Draw ��k
            MessageBox.Show(shape3.Draw());


            //����C��u�t
            AbstractFactoryPatternAbstractFactory colorFactory = AbstractFactoryPatternFactoryProducer.GetFactory("COLOR");

            //����C�⬰ Red ����H
            AbstractFactoryPatternColor color1 = colorFactory.GetColor("RED");

            //�ե� Red �� Fill ��k
            MessageBox.Show(color1.Fill());

            //����C�⬰ Green ����H
            AbstractFactoryPatternColor color2 = colorFactory.GetColor("GREEN");

            //�ե� Green �� Fill ��k
            MessageBox.Show(color2.Fill());


            //����C�⬰ Blue ����H
            AbstractFactoryPatternColor color3 = colorFactory.GetColor("BLUE");

            //�ե� Blue �� Fill ��k
            MessageBox.Show(color3.Fill());


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Singleton1.GetInstance().ShowMessage());
            MessageBox.Show(Singleton2.GetSingleton().ShowMessage());
            MessageBox.Show(Singleton3.GetInstance().ShowMessage());
            MessageBox.Show(Singleton4.Instance.ShowMessage());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuilderPatternMealBuilder mealBuilder = new BuilderPatternMealBuilder();

            BuilderPatternMeal vegMeal = mealBuilder.prepareVegMeal();
            string vegMealItems = "Veg Meal\n" + vegMeal.showItems() + "Total Cost: " + vegMeal.getCost() + "\n";

            BuilderPatternMeal nonVegMeal = mealBuilder.prepareNonVegMeal();
            string nonVegMealItems = "\nNon-Veg Meal\n" + nonVegMeal.showItems() + "Total Cost: " + nonVegMeal.getCost() + "\n";

            MessageBox.Show(vegMealItems + nonVegMealItems);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrototypePatternShapeCache.LoadCache();

            PrototypePatternShape clonedShape = (PrototypePatternShape)PrototypePatternShapeCache.GetShape("1");
            MessageBox.Show("Shape : " + clonedShape.GetType());

            PrototypePatternShape clonedShape2 = (PrototypePatternShape)PrototypePatternShapeCache.GetShape("2");
            MessageBox.Show("Shape : " + clonedShape2.GetType());

            PrototypePatternShape clonedShape3 = (PrototypePatternShape)PrototypePatternShapeCache.GetShape("3");
            MessageBox.Show("Shape : " + clonedShape3.GetType());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdapterPatternAudioPlayer audioPlayer = new AdapterPatternAudioPlayer();
            MessageBox.Show(audioPlayer.Play("mp3", "beyond the horizon.mp3"));
            MessageBox.Show(audioPlayer.Play("mp4", "alone.mp4"));
            MessageBox.Show(audioPlayer.Play("vlc", "far far away.vlc"));
            MessageBox.Show(audioPlayer.Play("avi", "mind me.avi"));
        }

        private void button7_Click(object sender, EventArgs e)
        {

            BridgeShape redCircle = new BridgeCircle(100, 100, 10, new BridgeRedCircle());
            BridgeShape greenCircle = new BridgeCircle(100, 100, 10, new BridgeGreenCircle());

            MessageBox.Show(redCircle.Draw());
            MessageBox.Show(greenCircle.Draw());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<FilterPatternPerson> persons = new List<FilterPatternPerson>();

            persons.Add(new FilterPatternPerson("Robert", "Male", "Single"));
            persons.Add(new FilterPatternPerson("John", "Male", "Married"));
            persons.Add(new FilterPatternPerson("Laura", "Female", "Married"));
            persons.Add(new FilterPatternPerson("Diana", "Female", "Single"));
            persons.Add(new FilterPatternPerson("Mike", "Male", "Single"));
            persons.Add(new FilterPatternPerson("Bobby", "Male", "Single"));

            FilterPatternCriteria male = new FilterPatternCriteriaMale();
            FilterPatternCriteria female = new FilterPatternCriteriaFemale();
            FilterPatternCriteria single = new FilterPatternCriteriaSingle();
            FilterPatternCriteria singleMale = new FilterPatternAndCriteria(single, male);
            FilterPatternCriteria singleOrFemale = new FilterPatternOrCriteria(single, female);

            MessageBox.Show("Males: ");
            PrintPersons(male.MeetCriteria(persons));

            MessageBox.Show("\nFemales: ");
            PrintPersons(female.MeetCriteria(persons));

            MessageBox.Show("\nSingle Males: ");
            PrintPersons(singleMale.MeetCriteria(persons));

            MessageBox.Show("\nSingle Or Females: ");
            PrintPersons(singleOrFemale.MeetCriteria(persons));
        }

        public void PrintPersons(List<FilterPatternPerson> persons)
        {
            foreach (var person in persons)
            {
                MessageBox.Show("Person : [ Name : " + person.GetName()
                    + ", Gender : " + person.GetGender()
                    + ", Marital Status : " + person.GetMaritalStatus()
                    + " ]");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CompositePatternEmployee CEO = new CompositePatternEmployee("John", "CEO", 30000);

            CompositePatternEmployee headSales = new CompositePatternEmployee("Robert", "Head Sales", 20000);

            CompositePatternEmployee headMarketing = new CompositePatternEmployee("Michel", "Head Marketing", 20000);

            CompositePatternEmployee clerk1 = new CompositePatternEmployee("Laura", "Marketing", 10000);
            CompositePatternEmployee clerk2 = new CompositePatternEmployee("Bob", "Marketing", 10000);

            CompositePatternEmployee salesExecutive1 = new CompositePatternEmployee("Richard", "Sales", 10000);
            CompositePatternEmployee salesExecutive2 = new CompositePatternEmployee("Rob", "Sales", 10000);

            CEO.Add(headSales);
            CEO.Add(headMarketing);

            headSales.Add(salesExecutive1);
            headSales.Add(salesExecutive2);

            headMarketing.Add(clerk1);
            headMarketing.Add(clerk2);

            // Print all employees of the organization
            MessageBox.Show(CEO.ToString());
            foreach (CompositePatternEmployee headEmployee in CEO.GetSubordinates())
            {
                MessageBox.Show(headEmployee.ToString());
                foreach (CompositePatternEmployee employee in headEmployee.GetSubordinates())
                {
                    MessageBox.Show(employee.ToString());
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DecoratorPatternShape circle = new DecoratorPatternCircle();
            DecoratorPatternShapeDecorator redCircle = new DecoratorPatternRedShapeDecorator(new DecoratorPatternCircle());
            DecoratorPatternShapeDecorator redRectangle = new DecoratorPatternRedShapeDecorator(new DecoratorPatternRectangle());

            string result = "";

            result += "Circle with normal border\n";
            result += circle.Draw();

            result += "\n\nCircle of red border\n";
            result += redCircle.Draw();

            result += "\n\nRectangle of red border\n";
            result += redRectangle.Draw();

            MessageBox.Show(result);
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            ObserverPatternSubject subject = new ObserverPatternSubject();

            ObserverPatternHexaObserver hexa = new ObserverPatternHexaObserver(subject);
            ObserverPatternOctalObserver octal = new ObserverPatternOctalObserver(subject);
            ObserverPatternBinaryObserver binary = new ObserverPatternBinaryObserver(subject);

            string result = "";
            result += "First state change: 15\n";
            subject.SetState(15);
            result += hexa.Update() + "\n";
            result += octal.Update() + "\n";
            result += binary.Update() + "\n";

            result += "Second state change: 10\n";
            subject.SetState(10);
            result += hexa.Update() + "\n";
            result += octal.Update() + "\n";
            result += binary.Update() + "\n";

            MessageBox.Show(result);
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
