using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StepTestApp
{
    public class DatabaseContext : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « DatabaseContext » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « StepTestApp.DatabaseContext » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « DatabaseContext » dans le fichier de configuration de l'application.
        public DatabaseContext()
            : base("name=Database")
        {
            Database.SetInitializer<DatabaseContext>(new DropCreateDatabaseIfModelChanges<DatabaseContext>());
        }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<UserInfo> Users { get; set; }
        public static List<UserInfo> Search(string needle)
        {
            using (var context = new DatabaseContext())
            {
                return context.Users.Where(user => user.Name.Contains(needle)).ToList();
            }
        }

        public static void Delete(int id)
        {
            using (var context = new DatabaseContext())
            {
                context.Users.Remove(new UserInfo { Id = id });
                context.SaveChanges();
            }
        }

        public static void Add(UserInfo user)
        {
            using (var context = new DatabaseContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public static List<UserInfo> Retrieve()
        {
            using (var context = new DatabaseContext())
            {
                return context.Users.ToList();
            }
        }
    }

    

    public class UserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required] //the fields need to be complete before the user is added to the database
        public string Name { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public Rating Fitness { get; set; }

        [Required]
        public Sex Sex { get; set; }
    }
    public enum Rating //all the different posibilities of the fitness rating
    {
        Excellent,
        Good,
        Average,
        BelowAverage,
        Poor
    }

    public enum Sex //all the different posibilities of the sexe
    {
        Male,
        Female
    }
}