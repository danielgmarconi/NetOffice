//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace NetOffice.DAOApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary DAO 6, 12
	 /// </summary>
	[SupportByLibraryAttribute("DAO", 6,12)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum RecordsetOptionEnum
	{
		 /// <summary>
		 /// SupportByLibrary DAO 6, 12
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByLibraryAttribute("DAO", 6,12)]
		 dbDenyWrite = 1,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByLibraryAttribute("DAO", 6,12)]
		 dbDenyRead = 2,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByLibraryAttribute("DAO", 6,12)]
		 dbReadOnly = 4,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByLibraryAttribute("DAO", 6,12)]
		 dbAppendOnly = 8,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByLibraryAttribute("DAO", 6,12)]
		 dbInconsistent = 16,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12
		 /// </summary>
		 /// <remarks>32</remarks>
		 [SupportByLibraryAttribute("DAO", 6,12)]
		 dbConsistent = 32,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12
		 /// </summary>
		 /// <remarks>64</remarks>
		 [SupportByLibraryAttribute("DAO", 6,12)]
		 dbSQLPassThrough = 64,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12
		 /// </summary>
		 /// <remarks>128</remarks>
		 [SupportByLibraryAttribute("DAO", 6,12)]
		 dbFailOnError = 128,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12
		 /// </summary>
		 /// <remarks>256</remarks>
		 [SupportByLibraryAttribute("DAO", 6,12)]
		 dbForwardOnly = 256,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12
		 /// </summary>
		 /// <remarks>512</remarks>
		 [SupportByLibraryAttribute("DAO", 6,12)]
		 dbSeeChanges = 512,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12
		 /// </summary>
		 /// <remarks>1024</remarks>
		 [SupportByLibraryAttribute("DAO", 6,12)]
		 dbRunAsync = 1024,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12
		 /// </summary>
		 /// <remarks>2048</remarks>
		 [SupportByLibraryAttribute("DAO", 6,12)]
		 dbExecDirect = 2048
	}
}