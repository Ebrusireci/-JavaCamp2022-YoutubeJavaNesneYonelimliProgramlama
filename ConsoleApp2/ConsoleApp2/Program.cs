using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program

    {

        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager(new Customer(), new MilitaryCreditManager());
            customerManager.GiveCredit();

            Console.ReadLine();
        }






    }
    }

    class Customer
    {
        public Customer()
        {
            Console.WriteLine(" müşteri nesnesi başlatıldı");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public string City { get; set; }
       
    }
    class Company : Customer
    {
 public string TaxNumber { get; set; }
public string CompanyName { get; set; }
    }

    class Person : Customer
    {
 public string NationalIdentity { get; set; }
    }


    class CreditManager
    {
        
       
        public void Calculate(int creditType)
        {
            Console.WriteLine("Hesaplandı");
        }
        public void Save()
        {
            Console.WriteLine("Kredi verildi");
        }

    }
    interface ICreditManager  {
        void Calculate();
      
        void Save();
    }
abstract class BaseCreditManager : ICreditManager
{
    public abstract void Calculate();

    public virtual void Save()
    {
        Console.WriteLine("Kaydedildi");
    }
}

class TeacherCreditManager : BaseCreditManager,ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Öğretmen kredisi hesaplandı");
        }


        
        }
    
    class MilitaryCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Asker kredisi hesaplandı");
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
    class CustomerManager
    {
        private Customer _customer;
        ICreditManager _creditManager;
        public CustomerManager(Customer customer, ICreditManager creditManager)
        {
            _customer = customer;
            _creditManager = creditManager;
        }
        public void Save(Customer customer)
        {
            Console.WriteLine("Müşteri Kaydedildi : ");
        }
        public void Delete()
        {
            Console.WriteLine("Müşteri Silindi : " );
        }
        public void GiveCredit()
        {
            _creditManager.Calculate();
            Console.WriteLine("Kredi verildi");
        }
       


        }
    

    


        
  

