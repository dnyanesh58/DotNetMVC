using System.ComponentModel.DataAnnotations;
namespace crud;

public class Crudcontact
{
    [Required]
    public int id { get; set; }
    [Required]
    public String name { get; set; }
    [Required]
    public String email {get;set;}
    [Required]
    public String contact {get;set;}

    public Crudcontact()
    {
        
    }
    public Crudcontact(String name,string email,String contact)
    {
        this.name=name;
        this.email=email;
        this.contact=contact;
    }
}
