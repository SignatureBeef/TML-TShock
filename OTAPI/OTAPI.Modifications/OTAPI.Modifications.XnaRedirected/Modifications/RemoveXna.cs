using OTAPI.Patcher.Engine.Modification;

using System.Linq;

namespace OTAPI.Patcher.Engine.Modifications.Patches
{
	/// <summary>
	/// Replaces all Xna references to use OTAPI.Xna.dll
	/// </summary>
	[Ordered(1)]
	public class RemoveXna : ModificationBase
	{
		public override System.Collections.Generic.IEnumerable<string> AssemblyTargets => new[]
		{
			"TerrariaServer, Version=1.3.5.3, Culture=neutral, PublicKeyToken=null",
			"ReLogic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
			"Terraria, Version=1.3.5.1, Culture=neutral, PublicKeyToken=null" // TML needed for audio etc from streams
		};
		public override string Description => "Redirecting OTAPI Xna references to MS...";

		public override void Run()
		{
			//var asm_fw = typeof(Microsoft.Xna.Framework.Vector2).Assembly;
			//var asm_game = typeof(Microsoft.Xna.Framework.Game).Assembly;
			//var asm_gfx = typeof(Microsoft.Xna.Framework.Graphics.AlphaTestEffect).Assembly;
			//var asm_x = typeof(Microsoft.Xna.Framework.Audio.AudioEngine).Assembly;

			//var c = this.SourceDefinition.MainModule.Import(typeof(System.Runtime.CompilerServices.TypeForwardedToAttribute).GetConstructors().Single());

			//var types = new[] {
			//	asm_fw,
			//	asm_game,
			//	asm_gfx,
			//	asm_x
			//}.SelectMany(a => a.GetExportedTypes()).ToArray();
			//foreach (var type in types)
			//{
			//	var a = new Mono.Cecil.CustomAttribute(c);
			//	a.ConstructorArguments.Add(new Mono.Cecil.CustomAttributeArgument(
			//		this.SourceDefinition.MainModule.Import(typeof(System.Type)),
			//		 this.SourceDefinition.MainModule.Import(type)
			//		));

			//	this.SourceDefinition.CustomAttributes.Add(a);
			//}

			////Context.OTAPI.MainModue.Resources.Clear();

			//System.AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

			//var xnaFramework = SourceDefinition.MainModule.AssemblyReferences
			//	.Where(x => x.Name.StartsWith("Microsoft.Xna.Framework"))
			//	.ToArray();

			//for (var x = 0; x < xnaFramework.Length; x++)
			//{
			//	xnaFramework[x].Name = "OTAPI.Modifications.Xna"; //TODO: Fix me, ILRepack is adding .dll to the asm name      Context.OTAPI.Assembly.Name.Name;
			//	xnaFramework[x].PublicKey = ModificationDefinition.Name.PublicKey;
			//	xnaFramework[x].PublicKeyToken = ModificationDefinition.Name.PublicKeyToken;
			//	xnaFramework[x].Version = ModificationDefinition.Name.Version;
			//}

			//////To resolve the "OTAPI" from above until the .dll can be corrected.
			//Context.AssemblyResolver.AssemblyResolve += AssemblyResolver_AssemblyResolve;
		}

		//private System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, System.ResolveEventArgs args)
		//{
		//	if (args.Name.Contains("Xna"))
		//	{
		//		return System.Reflection.Assembly.GetExecutingAssembly();
		//	}
		//	return null;
		//}
	}
}
