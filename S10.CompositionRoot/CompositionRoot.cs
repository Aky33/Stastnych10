using DryIoc;
using S10.DataAccessLayer.Implementations;
using S10.DataAccessLayer.Interfaces;
using S10.ServiceLayer.Implementations;
using S10.ServiceLayer.Interfaces;
using System;

namespace S10.CompositionRoot
{
    public class CompositionRoot
    {
        public Container Container { get; set; }

        public CompositionRoot()
        {
            Container = new Container();
        }

        public void Compose()
        {
            string connection = "Data Source=database.db; Version = 3; New = True; Compress = True;";

            Container.UseInstance(connection);
            Container.Register<ITahDao, TahDao>(Reuse.Singleton);

            Container.Register<IVypocetService, VypocetService>();
            Container.Register<ITahService, TahService>();

            CreateDB();
        }

        private void CreateDB()
        {
            try             //Pokus se vytvořit potřebné tabulky, pokud již neexistují
            {
                Container.Resolve<ITahService>().VytvorTabulku();
            }
            catch (Exception e)
            {

            }
        }
    }
}
