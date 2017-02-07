﻿using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming.Values
{
    public class RichTextValue : StringValue
    {
        public IRichTextString Value;

        public CellType GetType()
        {
            return CellType.String;
        }


        public override bool IsRichText()
        {
            return true;
        }
    }
}
