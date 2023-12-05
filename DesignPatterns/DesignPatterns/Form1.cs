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

            // 獲取Circle物件並調用其draw方法。
            FactoryPatternShape shape1 = shapeFactory.GetShape("FactoryPatternCircle");

            // 調用Circle的draw方法並在MessageBox中顯示結果。
            MessageBox.Show(shape1.Draw());

            // 獲取Rectangle物件並調用其draw方法。
            FactoryPatternShape shape2 = shapeFactory.GetShape("FactoryPatternRectangle");

            // 調用Rectangle的draw方法並在MessageBox中顯示結果。
            MessageBox.Show(shape2.Draw());

            // 獲取Square物件並調用其draw方法。
            FactoryPatternShape shape3 = shapeFactory.GetShape("FactoryPatternSquare");

            // 調用Square的draw方法並在MessageBox中顯示結果。
            MessageBox.Show(shape3.Draw());
        }
    }
}
