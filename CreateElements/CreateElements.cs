using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AdvanceSteel.Geometry;
using Autodesk.AdvanceSteel.Modelling;
using Autodesk.AdvanceSteel.Profiles;
using Autodesk.AdvanceSteel.CADAccess;
using Autodesk.AdvanceSteel.DocumentManagement;
using Autodesk.AdvanceSteel.Runtime;

namespace HelloWorld
{
    internal class CreateElements
    {
        [CommandMethodAttribute("TEST_GROUP", "CreateElements", "CreateElements", CommandFlags.Modal | CommandFlags.UsePickSet | CommandFlags.Redraw)]
        public void Create()
        {
            using (DocumentAccess da = new DocumentAccess(null,false))
            {
                //create column (vertical beam) with a default size
                ProfileName profName = new ProfileName();
                ProfilesManager.GetProfTypeAsDefault("I", out profName);

                Point3d beamStart = Point3d.kOrigin;
                Point3d beamEnd = new Point3d(0, 0, 3500);

                StraightBeam myBeam = new StraightBeam(profName.Name, beamStart, beamEnd, Vector3d.kXAxis);
                myBeam.WriteToDb();
                da.Commit();
            }
        }
    }
}
