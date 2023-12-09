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
    }
}
