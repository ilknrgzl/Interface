using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {

        // interface new'lenemez
        static void Main(string[] args)
        {
            IPersonManager personManager = new CustomerManager(); //interfaceler referans tiplerdir. interfaceler onu implement eden cass ın referans numarasını tutabilirler.
            personManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());

            projectManager.Add(new InternManager());

            Console.ReadLine();
        }

    }

    interface IPersonManager  // interfacelerde bir imza belirleyip onu miras alan c lasslar da onu kullanmak zorunda ama icine kendi istedigini yazabilir.
    {
        //unimplemented operation
        void Add();
        void Update();

    }

    //inherits - class-------------------implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları burada bulunur
            Console.WriteLine("müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("müşteri güncellendi");
        }
    }



    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //prsonel ekleme kodlar
            Console.WriteLine("personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("personel güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            
            personManager.Add();
        }
        
    }


}
