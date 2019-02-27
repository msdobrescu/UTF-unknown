﻿/* ***** BEGIN LICENSE BLOCK *****
 * Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Mozilla Communicator client code.
 *
 * The Initial Developer of the Original Code is
 * Netscape Communications Corporation.
 * Portions created by the Initial Developer are Copyright (C) 1998
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 *
 * ***** END LICENSE BLOCK ***** */

/*
* The following part was imported from https://gitlab.freedesktop.org/uchardet/uchardet
* The implementation of this feature was originally done on https://gitlab.freedesktop.org/uchardet/uchardet/blob/master/src/LangModels/LangCroatianModel.cpp
* and adjusted to language specific support.
*/

namespace UtfUnknown.Core
{
    public class Windows_1250_CroatianModel : CroatianModel
    {
        // Generated by BuildLangModel.py
        // On: 2016-09-25 23:50:27.590137

        // Character Mapping Table:
        // ILL: illegal character.
        // CTR: control character specific to the charset.
        // RET: carriage/return.
        // SYM: symbol (punctuation) that does not belong to word.
        // NUM: 0 - 9.

        // Other characters are ordered by probabilities
        // (0 is the most common character in the language).

        // Orders are generic to a language. So the codepoint with order X in
        // CHARSET1 maps to the same character as the codepoint with the same
        // order X in CHARSET2 for the same language.
        // As such, it is possible to get missing order. For instance the
        // ligature of 'o' and 'e' exists in ISO-8859-15 but not in ISO-8859-1
        // even though they are both used for French. Same for the euro sign.

        private static byte[] CHAR_TO_ORDER_MAP = {
          CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,RET,CTR,CTR,RET,CTR,CTR, /* 0X */
          CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR, /* 1X */
          SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM, /* 2X */
          NUM,NUM,NUM,NUM,NUM,NUM,NUM,NUM,NUM,NUM,SYM,SYM,SYM,SYM,SYM,SYM, /* 3X */
          SYM,  0, 19, 20, 15,  2, 22, 17, 21,  1,  7,  9, 10, 12,  4,  3, /* 4X */
           14, 30,  6,  8,  5, 11, 13, 28, 29, 27, 16,SYM,SYM,SYM,SYM,SYM, /* 5X */
          SYM,  0, 19, 20, 15,  2, 22, 17, 21,  1,  7,  9, 10, 12,  4,  3, /* 6X */
           14, 30,  6,  8,  5, 11, 13, 28, 29, 27, 16,SYM,SYM,SYM,SYM,CTR, /* 7X */
          SYM,ILL,SYM,ILL,SYM,SYM,SYM,SYM,ILL,SYM, 23,SYM, 49, 50, 24, 51, /* 8X */
          ILL,SYM,SYM,SYM,SYM,SYM,SYM,SYM,ILL,SYM, 23,SYM, 52, 53, 24, 54, /* 9X */
          SYM,SYM,SYM, 40,SYM, 55,SYM,SYM,SYM,SYM, 56,SYM,SYM,SYM,SYM, 57, /* AX */
          SYM,SYM,SYM, 40,SYM,SYM,SYM,SYM,SYM, 58, 59,SYM, 60,SYM, 61, 62, /* BX */
           63, 41, 43, 64, 36, 65, 25, 39, 18, 31, 66, 47, 67, 68, 69, 70, /* CX */
           26, 71, 72, 44, 73, 74, 32,SYM, 75, 76, 48, 77, 33, 78, 79, 80, /* DX */
           81, 41, 43, 82, 36, 83, 25, 39, 18, 31, 84, 47, 85, 86, 87, 88, /* EX */
           26, 89, 90, 44, 91, 92, 32,SYM, 93, 94, 48, 95, 33, 96, 97,SYM, /* FX */
        };
        /*X0  X1  X2  X3  X4  X5  X6  X7  X8  X9  XA  XB  XC  XD  XE  XF */

        public Windows_1250_CroatianModel() : base(CHAR_TO_ORDER_MAP, "WINDOWS-1250")
        {
        }
    }
}
