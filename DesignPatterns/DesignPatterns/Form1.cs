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
    }
}
