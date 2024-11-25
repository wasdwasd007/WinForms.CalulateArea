namespace WinForms.CalulateArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีต้อนรับผู้ใช้งาน", "Welcome");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // คำนวณพื้นที่วงกลม
            try
            {
                double radius = double.Parse(txtRadius.Text);
                double circleArea = Math.PI * Math.Pow(radius, 2);
                lblResult.Text = "พื้นที่วงกลม: " + circleArea.ToString("F2") + " ตารางหน่วย";
            }
            catch
            {
                MessageBox.Show("กรุณากรอกข้อมูลที่ถูกต้องสำหรับรัศมี", "Error");
                txtRadius.Focus();
                txtRadius.SelectAll();
            }
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            // คำนวณพื้นที่สามเหลี่ยม
            try
            {
                double height = double.Parse(txtHeight.Text);
                double baseWidth = double.Parse(txtWidth.Text);
                double triangleArea = 0.5 * baseWidth * height;
                lblResult.Text = "พื้นที่สามเหลี่ยม: " + triangleArea.ToString("F2") + " ตารางหน่วย";
            }
            catch
            {
                MessageBox.Show("กรุณากรอกข้อมูลที่ถูกต้องสำหรับฐานและความสูง", "Error");
                txtHeight.Focus();
                txtHeight.SelectAll();
            }
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            // คำนวณพื้นที่หกเหลี่ยมด้านเท่า
            try
            {
                double hexagonWidth = double.Parse(txtHexagonWidth.Text);
                double hexagonArea = ((3 * Math.Sqrt(3)) / 2) * Math.Pow(hexagonWidth, 2);
                lblResult.Text = "พื้นที่หกเหลี่ยม: " + hexagonArea.ToString("F2") + " ตารางหน่วย";
            }
            catch
            {
                MessageBox.Show("กรุณากรอกข้อมูลที่ถูกต้องสำหรับด้านของหกเหลี่ยม", "Error");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHexagonWidth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
