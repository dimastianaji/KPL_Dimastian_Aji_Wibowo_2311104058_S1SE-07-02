using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

class User
{
    public string Username { get; set; }
    public string PasswordHash { get; set; }
}

class Program
{
    static string filePath = "users.json";
    static List<User> users = new List<User>();

    static void Main()
    {
        LoadUsers();

        Console.WriteLine("1. Registrasi\n2. Login");
        Console.Write("Pilih opsi: ");
        string pilihan = Console.ReadLine();

        if (pilihan == "1")
            Register();
        else if (pilihan == "2")
            Login();
        else
            Console.WriteLine("Pilihan tidak valid.");
    }

    static void Register()
    {
        Console.Write("Masukkan username: ");
        string username = Console.ReadLine();

        Console.Write("Masukkan password: ");
        string password = Console.ReadLine();

        if (!IsValidInput(username, password))
            return;

        string hashedPassword = HashPassword(password);
        users.Add(new User { Username = username, PasswordHash = hashedPassword });
        SaveUsers();

        Console.WriteLine("Registrasi berhasil!");
    }

    static void Login()
    {
        Console.Write("Masukkan username: ");
        string username = Console.ReadLine();

        Console.Write("Masukkan password: ");
        string password = Console.ReadLine();

        string hashedPassword = HashPassword(password);
        foreach (var user in users)
        {
            if (user.Username == username && user.PasswordHash == hashedPassword)
            {
                Console.WriteLine("Login berhasil!");
                return;
            }
        }

        Console.WriteLine("Login gagal. Username atau password salah.");
    }

    static bool IsValidInput(string username, string password)
    {
        if (password.Length < 8 || password.Length > 20)
        {
            Console.WriteLine("Password harus antara 8-20 karakter.");
            return false;
        }

        if (!Regex.IsMatch(password, @"[!@#$%^&*]"))
        {
            Console.WriteLine("Password harus mengandung minimal 1 karakter unik (!@#$%^&*).");
            return false;
        }

        if (password.ToLower().Contains(username.ToLower()))
        {
            Console.WriteLine("Password tidak boleh mengandung username.");
            return false;
        }

        return true;
    }

    static string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }

    static void LoadUsers()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }
    }

    static void SaveUsers()
    {
        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }
}
