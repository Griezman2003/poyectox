  using poyectox.models;
namespace poyectox.services
  
  {
    public class sabritaservice
    {
      static List <sabrita> sabritas {get;} 

      static int nextID2 = 4;

      static sabritaservice()
          {
         sabritas = new List<sabrita>{
          new sabrita {ID = 1, NAME = "doritos nachos", isglutenfree = false },
          new sabrita {ID = 2, NAME = "doritos incognita", isglutenfree = false },
           new sabrita {ID = 3, NAME = "doritos fuego", isglutenfree = false },   
          };
          }
          public static List<sabrita> GetAll()=> sabritas; 

          public static sabrita Get (int ID) =>sabritas.FirstOrDefault(p => p.ID == ID);

          public static void Add(sabrita sabrita)
          {
            sabrita.ID = nextID2++; 
            sabritas.Add(sabrita);
          }
             public static void Delete(int ID)
             {
              var sabrita = Get(ID);
              if(sabrita is null)
              return;

              sabritas.Remove(sabrita);
             }
            public static void update(sabrita sabrita)
            {
              var index = sabritas.FindIndex(pizza => pizza.ID == pizza.ID);
              if (index == -1)
              return;

              sabritas[index] = sabrita;
            }
    }
  }