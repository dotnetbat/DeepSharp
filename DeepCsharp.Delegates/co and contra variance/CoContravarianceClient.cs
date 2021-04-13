using System;

namespace DeepCsharp.Delegates.co_and_contra_variance
{
    public class CoContravarianceClient
    {
        // Covariance
        private delegate ParentClass ParentClassFactory();
        private delegate ChildClass ChildClassFactory();
        
        // Contravariance
        private delegate void ContravarianceDelegate(ChildClass childClass);
        
        // Generic delegate
        private delegate T GenericCovariantDelegate<out T>();
        private delegate T GenericCovariantDelegateWoOut<T>();
        
        private delegate void GenericContravariantDelegate<in T>(T obj);
        private delegate void GenericContravariantDelegateWoIn<T>(T obj);

        public static void DoClientWork()
        {
            // Covariance

            ParentClassFactory parentClassFactory;
            parentClassFactory = BuildChildClass; // See the result type. We can use return ChildClass instead of ParentClass IN METHOD.

            ChildClassFactory childClassFactory;
            // childClassFactory = BuildParentClass(); // This doesn't work
            
            
            
            // Contravariance

            ContravarianceDelegate contravarianceDelegate;
            contravarianceDelegate = DoSomething; // See the param type. We can use ParentClass instead of ChildClass IN METHOD's params.
            
            
            
            // Generic delegates

            GenericCovariantDelegate<ChildClass> genericCovariantDelegateChild = BuildChildClass; // same types
            GenericCovariantDelegate<ParentClass> genericCovariantDelegateParent2 = BuildChildClass;  // covariance
            GenericCovariantDelegate<ParentClass> genericCovariantDelegateParent = genericCovariantDelegateChild; // covariance
            
            GenericCovariantDelegateWoOut<ChildClass> genericCovariantDelegateChildWoOut = BuildChildClass; // same types
            GenericCovariantDelegateWoOut<ParentClass> genericCovariantDelegateParentWoOut2 = BuildChildClass;  // general delegates covariance of delegates is still working
            //GenericCovariantDelegateWoOut<ParentClass> genericCovariantDelegateParentWoOut = genericCovariantDelegateChildWoOut; // covariance doesn't work without OUT keyword


            GenericContravariantDelegate<ParentClass> genericContravariantDelegateParent = DoSomething; // same types
            GenericContravariantDelegate<ChildClass> genericContravariantDelegateChild = DoSomething; // contravariance
            GenericContravariantDelegate<ChildClass> genericContravariantDelegateChild2 = genericContravariantDelegateParent; // contravariance
            
            GenericContravariantDelegateWoIn<ParentClass> genericContravariantDelegateParentWoOut = DoSomething; // same types
            GenericContravariantDelegateWoIn<ChildClass> genericContravariantDelegateChildWoOut2 = DoSomething;  // general delegates contravariance of delegates is still working
            //GenericContravariantDelegateWoIn<ChildClass> genericContravariantDelegateChildWoOut = genericContravariantDelegateParentWoOut; // covariance doesn't work without IN keyword
        }
        
        private static ChildClass BuildChildClass() => new ChildClass();

        private static ParentClass BuildParentClass() => new ParentClass();

        private static void DoSomething(ParentClass parentClass) => Console.WriteLine("1");
    }
}