using System;

// Modelo

/*
 * En este ejemplo se hace uso del patrón arquitectónico MVC 
 * (Modelo-Vista-Controlador). Este patrón separa 
 * la lógica de negocio (Modelo), la presentación 
 * (Vista) y el control (Controlador)
 */
public class UserModel
{
    public string Name { get; set; }
    public int Age { get; set; }
}

// Vista
public class UserView
{
    public void DisplayUserDetails(string name, int age)
    {
        Console.WriteLine($"Detalles de Usuario: Nombre - {name}, Edad - {age}");
    }
}

// Controlador
public class UserController
{
    private UserModel userModel;
    private UserView userView;

    public UserController(UserModel userModel, UserView userView)
    {
        this.userModel = userModel;
        this.userView = userView;
    }

    public void SetUserData(string name, int age)
    {
        userModel.Name = name;
        userModel.Age = age;
    }

    public void UpdateView()
    {
        userView.DisplayUserDetails(userModel.Name, userModel.Age);
    }
}

class Program
{
    static void Main()
    {
        // Crear instancias de Model, View y Controller
        UserModel userModel = new UserModel();
        UserView userView = new UserView();
        UserController userController = new UserController(userModel, userView);

        // Establecer datos del usuario y actualizar la vista
        userController.SetUserData("Juan Lopez", 30);
        userController.UpdateView();

        // Modificar datos del usuario y volver a actualizar la vista
        userController.SetUserData("Kenneth Taipe", 21);
        userController.UpdateView();

        Console.ReadLine();


    }
}
