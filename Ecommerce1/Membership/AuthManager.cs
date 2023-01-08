namespace Membership;

public static class AuthManager{

    public static bool Validate(string email,string password){
        bool status=false; 
        if(email=="rohit12@gmail.com" && password=="welcome"){
           status=true;
        }
        return status;
        //Console.WriteLine(status);
    }

    public static bool RegistarUser(string fname,string lname,string email,string contct,string location){
        
        bool status=false;
        try{
        User newUser=new User();
         newUser.FirstName=fname;
         newUser.LastName=lname;
         newUser.Email=email;
         newUser.Contact=contct;
         newUser.Location=location;

         status=true;
        }catch(Exception e){
           
        }finally{

        }
        return status;
    }
}