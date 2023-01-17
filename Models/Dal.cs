namespace dal;
using MySql.Data.MySqlClient;
using crud;
public class DbManager{

public static String str=@"server=localhost;port=3306;user=root;password=welcome@123;database=crud_contact";

public static List<Crudcontact> getallcontacts(){
    List<Crudcontact> contactlist = new List<Crudcontact>();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            String q1= "select * from contact_db";
            MySqlCommand cmd =new MySqlCommand(q1,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                Crudcontact contact = new Crudcontact{
                    id=int.Parse(reader["id"].ToString()),
                    name=reader["name"].ToString(),
                    email=reader["email"].ToString(),
                    contact = reader["contact"].ToString()
                };
                Console.WriteLine(contact);
                contactlist.Add(contact);
            }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }
    return contactlist;
}

public static void delcontact( int id){
    List<Crudcontact> contactlist = new List<Crudcontact>();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            String q1= "delete from contact_db where id="+id;
            MySqlCommand cmd =new MySqlCommand(q1,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            // while(reader.Read()){
            //     Crudcontact emp = new Crudcontact{
            //         id=int.Parse(reader["id"].ToString()),
            //         name=reader["name"].ToString(),
            //         contact = reader["contact"].ToString()
            //     };
            //     Console.WriteLine(emp);
            //     emplist.Add(emp);
            // }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }
   
}
public static Crudcontact findcontact(int id){
    Crudcontact contact=new Crudcontact();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            String q1= "select * from contact_db where id="+id;
            MySqlCommand cmd =new MySqlCommand(q1,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                 contact = new Crudcontact{
                    id=int.Parse(reader["id"].ToString()),
                    name=reader["name"].ToString(),
                    email=reader["email"].ToString(),
                    contact = reader["contact"].ToString()
                };
                Console.WriteLine(contact);
               
            }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }
    return contact;
}

public static void insertcontact(Crudcontact cont){
    List<Crudcontact> emplist = new List<Crudcontact>();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            String q1= $"insert into contact_db(id,name,email,contact) values ('{cont.id}','{cont.name}','{cont.email}','{cont.contact}')";
            MySqlCommand cmd =new MySqlCommand(q1,con);
            cmd.ExecuteNonQuery();
            // while(reader.Read()){
            //     Crudcontact emp = new Crudcontact{
            //         id=int.Parse(reader["id"].ToString()),
            //         name=reader["name"].ToString(),
            //         contact = reader["contact"].ToString()
            //     };
            //     Console.WriteLine(emp);
            //     emplist.Add(emp);
            // }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }
    
}

public static void updatecontact(Crudcontact cont){
    List<Crudcontact> contactlist = new List<Crudcontact>();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            Console.WriteLine(cont.id);
            String q1= $"update contact_db set name='{cont.name}',email='{cont.email}',contact='{cont.contact}' where id="+cont.id;
            MySqlCommand cmd =new MySqlCommand(q1,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            // while(reader.Read()){
            //     Crudcontact emp = new Crudcontact{
            //         id=int.Parse(reader["id"].ToString()),
            //         name=reader["name"].ToString(),
            //         contact = reader["contact"].ToString()
            //     };
            //     Console.WriteLine(emp);
            //     emplist.Add(emp);
            // }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }

}}