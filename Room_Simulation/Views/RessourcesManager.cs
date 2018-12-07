using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Views
{
    /// <summary>
    /// The ressources manager load all the ressources needed for the simulation
    /// to be beautiful and absolutly brilliant !
    /// </summary>
    public class RessourcesManager
    {
        //FIELDS
        public static Dictionary<string, Texture2D> Graphics;
        public static Dictionary<string, SoundEffect> Sounds;

        //CONSTRUCTOR

        //METHODS
        public void LoadGraphics(ContentManager content)
        { 
            List<string> ClientsSprites = new List<string>() { "client1", "client2", "client3", "client4", "client5", "client6", "client7", "client8", "client9", "client10", "client11", "client12", "client13" };
            List<string> FurnituresSprites = new List<string>() { "chairs", "exchange", "toilet" , "candle" };
            List<string> TablesSprites = new List<string>() { "table10", "table8", "table6", "table4", "table2" };
            List<string> TexturesSprites = new List<string>() { "allwalls", "brickwall", "grass", "ground", "objects", "people", "walls", "woodfloor" };
            List<string> UserInterfacesSprites = new List<string>() { "logo" };
            List<string> WorkersSprites = new List<string>() { "chefderang", "cooker", "hotelmaster", "serveur" };

            Graphics = new Dictionary<string, Texture2D>();

            foreach (var item in ClientsSprites)
            {
                Graphics.Add(item, content.Load<Texture2D>("Graphics/Clients/" + item));
            }
            foreach (var item in FurnituresSprites)
            {
                Graphics.Add(item, content.Load<Texture2D>("Graphics/Furnitures/" + item));
            }
            foreach (var item in TablesSprites)
            {
                Graphics.Add(item, content.Load<Texture2D>("Graphics/Tables/" + item));
            }
            foreach (var item in TexturesSprites)
            {
                Graphics.Add(item, content.Load<Texture2D>("Graphics/Textures/" + item));
            }
            foreach (var item in UserInterfacesSprites)
            {
                Graphics.Add(item, content.Load<Texture2D>("graphics/UserInterfaces/" + item));
            }
            foreach (var item in WorkersSprites)
            {
                Graphics.Add(item, content.Load<Texture2D>("graphics/Workers/" + item));
            }

            return;
        }

        public void LoadSounds(ContentManager content)
        {
            List<string> SoundsSources = new List<string>() { "wawa" , "coin" };

            Sounds = new Dictionary<string, SoundEffect>();

            foreach (var item in SoundsSources)
            {
                Sounds.Add(item, content.Load<SoundEffect>("Sounds/" + item));

            }
        }
    }
}
