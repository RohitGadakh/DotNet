namespace Membership;
public class User
{
private string fname;

public string FirstName{
    get{return fname;}
    set{this.fname=value;}
}

public string LastName{get;set;}
public string Email{get;set;}
public string Contact{get;set;}
public string Location{get;set;}


}
