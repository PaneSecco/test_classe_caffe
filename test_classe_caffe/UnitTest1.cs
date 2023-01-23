using macchinetta_caffe_finita;
namespace test_classe_caffe
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Macchinetta c1 = new Macchinetta(200, 50);
            Assert.True(c1.Limite_acqua==200);
            Assert.True(c1.Limite_caffe== 50);
        }
        [Fact]
        public void Test2()
        {
            Macchinetta c1 = new Macchinetta(200, 200);
            c1.Ricarica_acqua();
            c1.Ricarica_caffe();
            c1.Erogazione_normale();
            c1.Erogazione_normale();
            c1.Ricarica_acqua();
            c1.Ricarica_caffe();
            Assert.True(c1.Stato_acqua() == 200);
            Assert.True(c1.Stato_caffe() == 200);
        }
        [Fact]
        public void Test3()
        {
            Macchinetta c1 = new Macchinetta(120, 14);
            c1.Ricarica_acqua();
            c1.Ricarica_caffe();
            Assert.True(c1.Calcolo_massimo_normali()==2);
        }
        [Fact]
        public void Test4()
        {
            Macchinetta c1 = new Macchinetta(120, 140);
            c1.Ricarica_acqua();
            c1.Ricarica_caffe();
            Macchinetta c2 = new Macchinetta(120, 140);
            c2.Ricarica_acqua();
            c2.Ricarica_caffe();
            Assert.True(c1.Confronto(c1, c2)==c2);
        }
        [Fact]
        public void Test5()
        {
            Macchinetta c1 = new Macchinetta(120, 140);
            c1.Ricarica_acqua();
            c1.Ricarica_caffe();
            c1.Erogazione_normale();
            Assert.False(c1.Stato_acqua() == 120);
            c1.Ricarica_acqua();
            c1.Ricarica_caffe();
            c1.Erogazione_lungo();
            Assert.False(c1.Stato_acqua() == 120);
            //Assert.Throws<Exception>(() => );
        }

        [Fact]
        public void Test6()
        {
            Macchinetta c1 = new Macchinetta(120, 140);
            Assert.Throws<Exception>(() => c1.Erogazione_normale());
            Assert.Throws<Exception>(() => c1.Erogazione_lungo());
        }
        [Fact]
        public void Test7()
        {
            Macchinetta c1;
            Assert.Throws<Exception>(() => c1=new Macchinetta(-22, -88));
        }
    }
}