using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libVillageois
{
    public class Villageois
    {
        private string nom;

        private int poids;

        private bool malade;

        private Potion maPotion;


        public Villageois(string nom)
        {
            this.nom = nom;
            this.malade = false;
        }

        public Villageois(string nom, int poids, bool malade)
        {
            this.nom = nom;
            this.poids = poids;
            this.malade = malade;

        }
        public Villageois(string nom, int poids, bool malade, int potion)
        {
            this.nom = nom;
            this.poids = poids;
            this.malade = malade;
            this.maPotion = new Potion(potion);

        }

        public string getNom() { return this.nom; }

        public int getPoids() { return this.poids; }

        public bool getMalade() { return this.malade; }

        public void setPoids(int p) { this.poids = p; }

        public override string ToString()
        {
            string mal = "Malade";
            if (!this.malade) mal = "pas malade";
            return $"Le villageois se nomme {nom} peut soulever {poids} et est {mal} ";
        }

        public int poidsSouleve()

        {
            return poids / 5;
        }

        public void setdoses(int n)

        {
            maPotion.ajouterDose(n);

        }

        public Potion 
            getPotion() 
        { 
           return maPotion; 
        }
        
      
        
       

  
    
    
    
    
    
    
    
    
    
    
    
    
    }


}
