using Renci.SshNet.Messages.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_1.TestDataBase
{
	class Commons
	{
		// 공동 DB 연결 문자열
		public static readonly string CONNSTR = "Data Source=127.0.0.1;Port=3306;Database=bookrentalshop;UID=root;Password=mysql_p@ssw0rd";

		public enum BaseMode
		{
			NONE,       // 기본
			INSERT,     // 입력
			UPDATE,     // 수정
			DELETE,     // 삭제
			SELECT
		}

	}
}
