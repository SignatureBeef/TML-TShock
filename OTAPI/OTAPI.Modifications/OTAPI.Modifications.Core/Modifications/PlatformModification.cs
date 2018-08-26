using OTAPI.Patcher.Engine.Extensions;
using OTAPI.Patcher.Engine.Modification;
using System.Collections.Generic;

namespace OTAPI.Modifications
{
	public class PlatformModification : ModificationBase
	{
		public override IEnumerable<string> AssemblyTargets => new[]
		{
			"TerrariaServer, Version=1.3.5.3, Culture=neutral, PublicKeyToken=null",
			"Terraria, Version=1.3.5.1, Culture=neutral, PublicKeyToken=null","TerrariaServer, Version=1.3.5.1, Culture=neutral, PublicKeyToken=null" // TML
		};

		public override string Description => "Modifying readonly flag on ReLogic.OS.Platform.Current";

		public override void Run()
		{
			this.SourceDefinition.Type("ReLogic.OS.Platform").Field("Current").IsInitOnly = false;
		}
	}
}
