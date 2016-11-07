using LinqToTwitter.Common;
using LitJson;

namespace LinqToTwitter
{
	internal class ExtendedStatus
	{
		public ExtendedStatus()
		{
		}

		public ExtendedStatus( JsonData data )
		{
			if( data == null ) return;

			FullText = data.GetValue<string>( "full_text" );
			Entities = new Entities( data.GetValue<JsonData>( "entities" ) );
		}

		public Entities Entities { get; set; }
		public string FullText { get; set; }
	}
}