using System;


namespace D8S.E0001
{
    public class ServiceA
    {
        public ServiceA()
        {
        }
    }

    public class ServiceB
    {
        private ServiceA ServiceA { get; }


        public ServiceB(
            ServiceA serviceA)
        {
            this.ServiceA = serviceA;
        }
    }

    public class ServiceC
    {
        private ServiceB ServiceB { get; }


        public ServiceC(
            ServiceB serviceB)
        {
            this.ServiceB = serviceB;
        }
    }

    public class ServiceD
    {
        private ServiceA ServiceA { get; }
        private ServiceC ServiceC { get; }


        public ServiceD(
            ServiceA serviceA,
            ServiceC serviceC)
        {
            this.ServiceA = serviceA;
            this.ServiceC = serviceC;
        }
    }
}
