namespace Hospital.UnitTests
{
    [TestFixture]
    public class PatientTests
    {
        static Patient patient;

        [SetUp]
        public void Setup()
        {
            patient = new Patient("����", "������", 1378652370605432);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(patient.Name, Is.EqualTo("����"));
            Assert.That(patient.Surname, Is.EqualTo("������"));
            Assert.That(patient.PoliceNumber, Is.EqualTo(1378652370605432));
        }

        [Test]
        public void GetInfo_Patient_ValueString()
        {
            string expectedInfo = "���� ������. ";
            expectedInfo += "����� ������: 1378652370605432. ";

            Assert.That(patient.GetInfo(), Is.EqualTo(expectedInfo));
        }

        [Test]
        public void CompareToTest()
        {
            var �������� = new HospitalPatient("��������", "������", 2378752381606532, "����������������", 107);

            var ������� = new HospitalPatient("�������", "��������", 3478862392607632, "����������������", 103);

            var ���� = new HospitalPatient("����", "������", 4578972353608732, "�����������������", 115);

            Assert.That(�������.CompareTo(��������), Is.LessThan(0));
            Assert.That(����.CompareTo(����), Is.EqualTo(0));
        }
    }
}