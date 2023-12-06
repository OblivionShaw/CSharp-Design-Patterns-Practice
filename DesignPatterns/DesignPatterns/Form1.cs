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

        private void button2_Click(object sender, EventArgs e)
        {
            //獲取形狀工廠
            AbstractFactoryPatternAbstractFactory shapeFactory = AbstractFactoryPatternFactoryProducer.GetFactory("SHAPE");

            //獲取形狀為 Circle 的對象
            AbstractFactoryPatternShape shape1 = shapeFactory.GetShape("CIRCLE");

            //調用 Circle 的 Draw 方法
            MessageBox.Show(shape1.Draw());

            //獲取形狀為 Rectangle 的對象
            AbstractFactoryPatternShape shape2 = shapeFactory.GetShape("RECTANGLE");

            //調用 Rectangle 的 Draw 方法
            MessageBox.Show(shape2.Draw());

            //獲取形狀為 Square 的對象
            AbstractFactoryPatternShape shape3 = shapeFactory.GetShape("SQUARE");

            //調用 Square 的 Draw 方法
            MessageBox.Show(shape3.Draw());
            

            //獲取顏色工廠
            AbstractFactoryPatternAbstractFactory colorFactory = AbstractFactoryPatternFactoryProducer.GetFactory("COLOR");

            //獲取顏色為 Red 的對象
            AbstractFactoryPatternColor color1 = colorFactory.GetColor("RED");

            //調用 Red 的 Fill 方法
            MessageBox.Show(color1.Fill());

            //獲取顏色為 Green 的對象
            AbstractFactoryPatternColor color2 = colorFactory.GetColor("GREEN");

            //調用 Green 的 Fill 方法
            MessageBox.Show(color2.Fill());


            //獲取顏色為 Blue 的對象
            AbstractFactoryPatternColor color3 = colorFactory.GetColor("BLUE");

            //調用 Blue 的 Fill 方法
            MessageBox.Show(color3.Fill());


        }
    }
}
