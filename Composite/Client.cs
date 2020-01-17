using System;

namespace Composite
{
    public class Client
    {
        CompositeCP UAX = new CompositeCP("UAX");
        ClavePresupuestal clavePresupuestal = new ClavePresupuestal();

        public void ObtenerSaldoTotal()
        {
            decimal dSaldoTotal = 0.0M;            
            PrepararEstructuraUA1();
            PrepararEstructuraUA2();
            PrepararEstructuraUA3();
            PrepararEstructuraUA4();
            dSaldoTotal = UAX.ObtenerSaldoTotal();
        }

        private void PrepararEstructuraUA1()
        {
            CompositeCP UA1 = new CompositeCP("UA 1");
            CompositeCP UA11 = new CompositeCP("UA 1.1");
            CompositeCP UA111 = new CompositeCP("UA 1.1.1");
            clavePresupuestal.cId = "CP1";
            clavePresupuestal.dSaldoEnero = 10;
            clavePresupuestal.dSaldoFebrero = 20;
            clavePresupuestal.dSaldoMarzo = 30;

            LeafUA CP1 = new LeafUA(clavePresupuestal);
            UA111.Agregar(CP1);
            UA11.Agregar(UA111);
            UA1.Agregar(UA11);
            UAX.Agregar(UA1);

            CompositeCP UA12 = new CompositeCP("UA 1.2");
            CompositeCP UA121 = new CompositeCP("UA 1.2.1");
            clavePresupuestal.cId = "CP12";
            clavePresupuestal.dSaldoEnero = 10;
            clavePresupuestal.dSaldoFebrero = 20;
            clavePresupuestal.dSaldoMarzo = 30;

            LeafUA CP12 = new LeafUA(clavePresupuestal);
            UA121.Agregar(CP12);
            UA12.Agregar(UA121);
            UA1.Agregar(UA12);
        }

        private void PrepararEstructuraUA2()
        {
            CompositeCP UA2 = new CompositeCP("UA 2");
            CompositeCP UA21 = new CompositeCP("UA 2.1");
            CompositeCP UA211 = new CompositeCP("UA 2.1.1");
            clavePresupuestal.cId = "CP2";
            clavePresupuestal.dSaldoEnero = 10;
            clavePresupuestal.dSaldoFebrero = 20;
            clavePresupuestal.dSaldoMarzo = 30;

            LeafUA CP2 = new LeafUA(clavePresupuestal);
            UA211.Agregar(CP2);
            UA21.Agregar(UA211);
            UA2.Agregar(UA21);
            UAX.Agregar(UA2);
        }

        private void PrepararEstructuraUA3()
        {
            CompositeCP UA3 = new CompositeCP("UA 3");
            CompositeCP UA31 = new CompositeCP("UA 3.1");
            clavePresupuestal.cId = "CP3";
            clavePresupuestal.dSaldoEnero = 10;
            clavePresupuestal.dSaldoFebrero = 20;
            clavePresupuestal.dSaldoMarzo = 30;

            LeafUA CP3 = new LeafUA(clavePresupuestal);
            UA31.Agregar(CP3);
            UA3.Agregar(UA31);
            UAX.Agregar(UA3);
        }

        private void PrepararEstructuraUA4()
        {
            CompositeCP UA4 = new CompositeCP("UA 4");
            clavePresupuestal.cId = "CP4";
            clavePresupuestal.dSaldoEnero = 10;
            clavePresupuestal.dSaldoFebrero = 20;
            clavePresupuestal.dSaldoMarzo = 30;

            LeafUA CP4 = new LeafUA(clavePresupuestal);
            UA4.Agregar(CP4);
            UAX.Agregar(UA4);
        }
    }
}
