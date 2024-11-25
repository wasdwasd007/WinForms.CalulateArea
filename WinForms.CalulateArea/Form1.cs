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
            MessageBox.Show("�Թ�յ�͹�Ѻ�����ҹ", "Welcome");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // �ӹǳ��鹷��ǧ���
            try
            {
                double radius = double.Parse(txtRadius.Text);
                double circleArea = Math.PI * Math.Pow(radius, 2);
                lblResult.Text = "��鹷��ǧ���: " + circleArea.ToString("F2") + " ���ҧ˹���";
            }
            catch
            {
                MessageBox.Show("��سҡ�͡�����ŷ��١��ͧ����Ѻ�����", "Error");
                txtRadius.Focus();
                txtRadius.SelectAll();
            }
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            // �ӹǳ��鹷������������
            try
            {
                double height = double.Parse(txtHeight.Text);
                double baseWidth = double.Parse(txtWidth.Text);
                double triangleArea = 0.5 * baseWidth * height;
                lblResult.Text = "��鹷������������: " + triangleArea.ToString("F2") + " ���ҧ˹���";
            }
            catch
            {
                MessageBox.Show("��سҡ�͡�����ŷ��١��ͧ����Ѻ�ҹ��Ф����٧", "Error");
                txtHeight.Focus();
                txtHeight.SelectAll();
            }
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            // �ӹǳ��鹷��ˡ���������ҹ���
            try
            {
                double hexagonWidth = double.Parse(txtHexagonWidth.Text);
                double hexagonArea = ((3 * Math.Sqrt(3)) / 2) * Math.Pow(hexagonWidth, 2);
                lblResult.Text = "��鹷��ˡ�������: " + hexagonArea.ToString("F2") + " ���ҧ˹���";
            }
            catch
            {
                MessageBox.Show("��سҡ�͡�����ŷ��١��ͧ����Ѻ��ҹ�ͧˡ�������", "Error");
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
