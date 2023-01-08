namespace HR;
public class Employee
{
 public int Id{get;set;}
public string Fname{get;set;}
public string Lname{get;set;}
public string Email{get;set;}
public int Contact{get;set;}
public string Location{get;set;}
public DateTime BirthDate{get;set;}
public float DA{get;set;}
public float HRA{get;set;}
public float BasicSal{get;set;}

public Employee():this(1,"Rohit","Gadakh","rohit12@gamil.com",12345,new DateTime(2000,9,31),
                        1500,10000,35000){


}
public Employee(int id,string fname,string lname,string email,
               int contact,string location,DateTime birthdate,
                float da,float hra,float basicSal){

     this.Id=id;
     this.FirstName=fname;
     this.Lname=lname;
     this.Email=email;
     this.Contact=contact;
     this.Location=location;
     this.BirthDate=birthdate;
     this.DA=da;
     this.HRA=hra;
     this.BasicSal=basicSal;
}

public abstract void DoWorking(){

}

public virtual float ComputeSalary(){
     float sal=(DA *20)+BasicSalary + HRA;
     return sal;
}

  public override string ToString(){
    
  }

}
