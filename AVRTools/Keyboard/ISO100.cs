﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVRKeys.Keyboard
{
    public partial class PanelMacro
    {
        #region kecap
        string[] keycap = new string[21]{
"0,0,1,0,0,MOUSE_LEFT,",
"1,0,1,0,0,MOUSE_RIGHT,",
"2,0,1,0,0,MOUSE_MID,",
"3,0,1,0,0,MOUSE_4,",
"4,0,1,0,0,MOUSE_5,",


//"0,1,1,0,0,KEY_FN,",
//"1,1,1,0,0,,",

"0,1,2,0,0,TRANSPORT_NEXT_TRACK,",
"2,1,2,0,0,TRANSPORT_PREV_TRACK,",
"4,1,2,0,0,TRANSPORT_STOP,",
"6,1,2,0,0,TRANSPORT_STOP_EJECT,",
"8,1,2,0,0,TRANSPORT_PLAY_PAUSE,",
"10,1,2,0,0,SYSTEM_POWER_DOWN,",
"12,1,2,0,0,SYSTEM_SLEEP,",
"14,1,2,0,0,SYSTEM_WAKE_UP,",

"0,2,1,0,0,MACRO0,",
"1,2,1,0,0,MACRO1,",
"2,2,1,0,0,MACRO2,",
"3,2,1,0,0,MACRO3,",
"4,2,1,0,0,MACRO4,",
"5,2,1,0,0,MACRO5,",
"6,2,1,0,0,MACRO6,",
"7,2,1,0,0,MACRO7,"
            };
        #endregion
    }
    public partial class PanelUS
    {
        #region kecap
        string[] keycap = new string[108]{
"0,0,1,5,0,KEY_ESC,",
"2,0,1,5,2,KEY_F1,",
"3,0,1,5,3,KEY_F2,",
"4,0,1,5,4,KEY_F3,",
"5,0,1,5,5,KEY_F4,",
"6.5,0,1,6,0,KEY_F5,",
"7.5,0,1,6,10,KEY_F6,",
"8.5,0,1,7,10,KEY_F7,",
"9.5,0,1,7,0,KEY_F8,",
"11,0,1,5,11,KEY_F9,",
"12,0,1,5,12,KEY_F10,",
"13,0,1,5,13,KEY_F11,",
"14,0,1,5,14,KEY_F12,",
"15,0,1,0,13,KEY_PRINTSCREEN,",
"16,0,1,7,6,KEY_SCROLL_LOCK,",
"17,0,1,7,9,KEY_PAUSE,",
"18,0,1,0,0,,",
"19,0,1,0,0,AUDIO_MUTE,",
"20,0,1,0,0,AUDIO_VOL_UP,",
"21,0,1,0,0,AUDIO_VOL_DOWN,",

"0,1,1,4,0,KEY_TILDE,",
"1,1,1,4,1,KEY_1,",
"2,1,1,4,2,KEY_2,",
"3,1,1,4,3,KEY_3,",
"4,1,1,4,4,KEY_4,",
"5,1,1,4,5,KEY_5,",
"6,1,1,6,1,KEY_6,",
"7,1,1,6,11,KEY_7,",
"8,1,1,7,11,KEY_8,",
"9,1,1,7,1,KEY_9,",
"10,1,1,4,10,KEY_0,",
"11,1,1,4,11,KEY_MINUS,",
"12,1,1,4,12,KEY_EQUAL,",
"13,1,2,4,14,KEY_BACKSPACE,",
"15,1,1,4,6,KEY_INSERT,",
"16,1,1,4,7,KEY_HOME,",
"17,1,1,4,8,KEY_PAGE_UP,",
"18,1,1,4,14,KEY_NUM_LOCK,",
"19,1,1,4,6,KEYPAD_SLASH,",
"20,1,1,4,7,KEYPAD_ASTERIX,",
"21,1,1,4,8,KEYPAD_MINUS,",
"0,2,1.5,3,0,KEY_TAB,",
"1.5,2,1,3,1,KEY_Q,",
"2.5,2,1,3,2,KEY_W,",
"3.5,2,1,3,3,KEY_E,",
"4.5,2,1,3,4,KEY_R,",
"5.5,2,1,3,5,KEY_T,",
"6.5,2,1,6,2,KEY_Y,",
"7.5,2,1,6,12,KEY_U,",
"8.5,2,1,7,12,KEY_I,",
"9.5,2,1,7,2,KEY_O,",
"10.5,2,1,3,10,KEY_P,",
"11.5,2,1,3,11,KEY_LEFT_BRACE,",
"12.5,2,1,3,12,KEY_RIGHT_BRACE,",
"13.5,2,1.5,3,13,KEY_BACKSLASH,",
"15,2,1,3,6,KEY_DELETE,",
"16,2,1,3,7,KEY_END,",
"17,2,1,3,8,KEY_PAGE_DOWN,",
"18,2,1,3,6,KEYPAD_7,",
"19,2,1,3,7,KEYPAD_8,",
"20,2,1,3,8,KEYPAD_9,",
"21,2,0.5,2,9,KEYPAD_PLUS,",

"0,3,1.75,2,0,KEY_CAPS_LOCK,",
"1.75,3,1,2,1,KEY_A,",
"2.75,3,1,2,2,KEY_S,",
"3.75,3,1,2,3,KEY_D,",
"4.75,3,1,2,4,KEY_F,",
"5.75,3,1,2,5,KEY_G,",
"6.75,3,1,6,3,KEY_H,",
"7.75,3,1,6,13,KEY_J,",
"8.75,3,1,7,13,KEY_K,",
"9.75,3,1,7,3,KEY_L,",
"10.75,3,1,2,10,KEY_SEMICOLON,",
"11.75,3,1,2,11,KEY_QUOTE,",
"12.75,3,2.25,2,13,KEY_ENTER,",
"18,3,1,2,6,KEYPAD_4,",
"19,3,1,2,7,KEYPAD_5,",
"20,3,1,2,8,KEYPAD_6,",

"0,4,2.25,1,0,KEY_SHIFT,",
"2.25,4,1,1,1,KEY_Z,",
"3.25,4,1,1,2,KEY_X,",
"4.25,4,1,1,3,KEY_C,",
"5.25,4,1,1,4,KEY_V,",
"6.25,4,1,1,5,KEY_B,",
"7.25,4,1,6,4,KEY_N,",
"8.25,4,1,6,14,KEY_M,",
"9.25,4,1,7,14,KEY_COMMA,",
"10.25,4,1,7,4,KEY_PERIOD,",
"11.25,4,1,1,10,KEY_SLASH,",
"12.25,4,2.75,1,11,KEY_RIGHT_SHIFT,",
"16,4,1,1,7,KEY_UP,",
"18,4,1,1,6,KEYPAD_1,",
"19,4,1,1,7,KEYPAD_2,",
"20,4,1,1,8,KEYPAD_3,",
"21,4,0.5,0,9,KEYPAD_ENTER,",

"0,5,1.25,0,0,KEY_CTRL,",
"1.25,5,1.25,0,1,KEY_GUI,",
"2.5,5,1.25,0,2,KEY_ALT,",
"3.75,5,6.25,6,5,KEY_SPACE,",
"10,5,1.25,7,5,KEY_RIGHT_ALT,",
"11.25,5,1.25,0,11,KEY_RIGHT_GUI,",
"12.5,5,1.25,0,11,KEY_FN,",
"13.75,5,1.25,6,6,KEY_RIGHT_CTRL,",
"15,5,1,6,9,KEY_LEFT,",
"16,5,1,0,6,KEY_DOWN,",
"17,5,1,0,8,KEY_RIGHT,",
"18,5,2,0,6,KEYPAD_0,",
"20,5,1,0,8,KEYPAD_PERIOD,"
            };
        #endregion
    }
    public partial class QMK100_ISO
        {
            #region kecap
            string[] keycap = new string[100]{
"0,0,1,5,0,KEY_ESC,",
"1,0,1,5,2,KEY_F1,",
"2,0,1,5,3,KEY_F2,",
"3,0,1,5,4,KEY_F3,",
"4,0,1,5,5,KEY_F4,",
"5,0,1,6,0,KEY_F5,",
"6,0,1,6,10,KEY_F6,",
"7,0,1,7,10,KEY_F7,",
"8,0,1,7,0,KEY_F8,",
"9,0,1,5,11,KEY_F9,",
"10,0,1,5,12,KEY_F10,",
"11,0,1,5,13,KEY_F11,",
"12,0,1,5,14,KEY_F12,",
"13,0,1,1,13,KEY_PRINTSCREEN,",
"14,0,1,2,14,KEY_PAUSE,",
"15,0,1,0,13,KEY_INSERT,",
"16,0,1,7,6,KEY_DELETE,",
"17,0,1,7,9,KEY_PAGE_UP,",
"18,0,1,7,8,KEY_PAGE_DOWN,",
"0,1,1,4,0,KEY_TILDE,",
"1,1,1,4,1,KEY_1,",
"2,1,1,4,2,KEY_2,",
"3,1,1,4,3,KEY_3,",
"4,1,1,4,4,KEY_4,",
"5,1,1,4,5,KEY_5,",
"6,1,1,6,1,KEY_6,",
"7,1,1,6,11,KEY_7,",
"8,1,1,7,11,KEY_8,",
"9,1,1,7,1,KEY_9,",
"10,1,1,4,10,KEY_0,",
"11,1,1,4,11,KEY_MINUS,",
"12,1,1,4,12,KEY_EQUAL,",
"13,1,2,4,14,KEY_BACKSPACE,",
"15,1,1,4,6,KEY_NUM_LOCK,",
"16,1,1,4,7,KEYPAD_SLASH,",
"17,1,1,4,8,KEYPAD_ASTERIX,",
"18,1,1,4,9,KEYPAD_MINUS,",
"0,2,1.5,3,0,KEY_TAB,",
"1.5,2,1,3,1,KEY_Q,",
"2.5,2,1,3,2,KEY_W,",
"3.5,2,1,3,3,KEY_E,",
"4.5,2,1,3,4,KEY_R,",
"5.5,2,1,3,5,KEY_T,",
"6.5,2,1,6,2,KEY_Y,",
"7.5,2,1,6,12,KEY_U,",
"8.5,2,1,7,12,KEY_I,",
"9.5,2,1,7,2,KEY_O,",
"10.5,2,1,3,10,KEY_P,",
"11.5,2,1,3,11,KEY_LEFT_BRACE,",
"12.5,2,1,3,12,KEY_RIGHT_BRACE,",
"13.5,2,1.5,3,13,KEY_BACKSLASH,",
"15,2,1,3,6,KEYPAD_7,",
"16,2,1,3,7,KEYPAD_8,",
"17,2,1,3,8,KEYPAD_9,",
"18,2,0.5,2,9,KEYPAD_PLUS,",
"0,3,1.75,3,0,KEY_CAPS_LOCK,",
"1.75,3,1,2,1,KEY_A,",
"2.75,3,1,2,2,KEY_S,",
"3.75,3,1,2,3,KEY_D,",
"4.75,3,1,2,4,KEY_F,",
"5.75,3,1,2,5,KEY_G,",
"6.75,3,1,6,3,KEY_H,",
"7.75,3,1,6,13,KEY_J,",
"8.75,3,1,7,13,KEY_K,",
"9.75,3,1,7,3,KEY_L,",
"10.75,3,1,2,10,KEY_SEMICOLON,",
"11.75,3,1,2,11,KEY_QUOTE,",
"12.75,3,2.25,2,13,KEY_ENTER,",
"15,3,1,2,6,KEYPAD_4,",
"16,3,1,2,7,KEYPAD_5,",
"17,3,1,2,8,KEYPAD_6,",
"0,4,2.25,1,0,KEY_SHIFT,",
"2.25,4,1,1,1,KEY_Z,",
"3.25,4,1,1,2,KEY_X,",
"4.25,4,1,1,3,KEY_C,",
"5.25,4,1,1,4,KEY_V,",
"6.25,4,1,1,5,KEY_B,",
"7.25,4,1,6,4,KEY_N,",
"8.25,4,1,6,14,KEY_M,",
"9.25,4,1,7,14,KEY_COMMA,",
"10.25,4,1,7,4,KEY_PERIOD,",
"11.25,4,1,1,10,KEY_SLASH,",
"12.25,4,1.75,1,11,KEY_RIGHT_SHIFT,",
"14,4,1,6,8,KEY_UP,",
"15,4,1,1,6,KEYPAD_1,",
"16,4,1,1,7,KEYPAD_2,",
"17,4,1,1,8,KEYPAD_3,",
"18,4,0.5,0,9,KEYPAD_ENTER,",
"0,5,1.25,0,0,KEY_CTRL,",
"1.25,5,1.25,0,1,KEY_GUI,",
"2.5,5,1.25,0,2,KEY_ALT,",
"3.75,5,6.25,6,5,KEY_SPACE,",
"10,5,1,7,5,KEY_RIGHT_ALT,",
"11,5,1,0,11,KEY_FN,",
"12,5,1,0,11,KEY_RIGHT_CTRL,",
"13,5,1,6,6,KEY_LEFT,",
"14,5,1,6,7,KEY_DOWN,",
"15,5,1,6,9,KEY_RIGHT,",
"16,5,1,0,6,KEYPAD_0,",
"17,5,1,0,8,KEYPAD_PERIOD,"
            };
            #endregion
        }
    public partial class QMK104_ISO
    {
        #region kecap
        string[] keycap = new string[104]{
"0,0,1,5,0,KEY_ESC,",
"2,0,1,5,2,KEY_F1,",
"3,0,1,5,3,KEY_F2,",
"4,0,1,5,4,KEY_F3,",
"5,0,1,5,5,KEY_F4,",
"6.5,0,1,6,0,KEY_F5,",
"7.5,0,1,6,10,KEY_F6,",
"8.5,0,1,7,10,KEY_F7,",
"9.5,0,1,7,0,KEY_F8,",
"11,0,1,5,11,KEY_F9,",
"12,0,1,5,12,KEY_F10,",
"13,0,1,5,13,KEY_F11,",
"14,0,1,5,14,KEY_F12,",
"15,0,1,0,13,KEY_PRINTSCREEN,",
"16,0,1,7,6,KEY_SCROLL_LOCK,",
"17,0,1,7,9,KEY_PAUSE,",
"0,1,1,4,0,KEY_TILDE,",
"1,1,1,4,1,KEY_1,",
"2,1,1,4,2,KEY_2,",
"3,1,1,4,3,KEY_3,",
"4,1,1,4,4,KEY_4,",
"5,1,1,4,5,KEY_5,",
"6,1,1,6,1,KEY_6,",
"7,1,1,6,11,KEY_7,",
"8,1,1,7,11,KEY_8,",
"9,1,1,7,1,KEY_9,",
"10,1,1,4,10,KEY_0,",
"11,1,1,4,11,KEY_MINUS,",
"12,1,1,4,12,KEY_EQUAL,",
"13,1,2,4,14,KEY_BACKSPACE,",
"15,1,1,4,6,KEY_INSERT,",
"16,1,1,4,7,KEY_HOME,",
"17,1,1,4,8,KEY_PAGE_UP,",
"18,1,1,4,14,KEY_NUM_LOCK,",
"19,1,1,4,6,KEYPAD_SLASH,",
"20,1,1,4,7,KEYPAD_ASTERIX,",
"21,1,1,4,8,KEYPAD_MINUS,",
"0,2,1.5,3,0,KEY_TAB,",
"1.5,2,1,3,1,KEY_Q,",
"2.5,2,1,3,2,KEY_W,",
"3.5,2,1,3,3,KEY_E,",
"4.5,2,1,3,4,KEY_R,",
"5.5,2,1,3,5,KEY_T,",
"6.5,2,1,6,2,KEY_Y,",
"7.5,2,1,6,12,KEY_U,",
"8.5,2,1,7,12,KEY_I,",
"9.5,2,1,7,2,KEY_O,",
"10.5,2,1,3,10,KEY_P,",
"11.5,2,1,3,11,KEY_LEFT_BRACE,",
"12.5,2,1,3,12,KEY_RIGHT_BRACE,",
"13.5,2,1.5,3,13,KEY_BACKSLASH,",
"15,2,1,3,6,KEY_DELETE,",
"16,2,1,3,7,KEY_END,",
"17,2,1,3,8,KEY_PAGE_DOWN,",
"18,2,1,3,6,KEYPAD_7,",
"19,2,1,3,7,KEYPAD_8,",
"20,2,1,3,8,KEYPAD_9,",
"21,2,0.5,2,9,KEYPAD_PLUS,",

"0,3,1.75,2,0,KEY_CAPS_LOCK,",
"1.75,3,1,2,1,KEY_A,",
"2.75,3,1,2,2,KEY_S,",
"3.75,3,1,2,3,KEY_D,",
"4.75,3,1,2,4,KEY_F,",
"5.75,3,1,2,5,KEY_G,",
"6.75,3,1,6,3,KEY_H,",
"7.75,3,1,6,13,KEY_J,",
"8.75,3,1,7,13,KEY_K,",
"9.75,3,1,7,3,KEY_L,",
"10.75,3,1,2,10,KEY_SEMICOLON,",
"11.75,3,1,2,11,KEY_QUOTE,",
"12.75,3,2.25,2,13,KEY_ENTER,",
"18,3,1,2,6,KEYPAD_4,",
"19,3,1,2,7,KEYPAD_5,",
"20,3,1,2,8,KEYPAD_6,",

"0,4,2.25,1,0,KEY_SHIFT,",
"2.25,4,1,1,1,KEY_Z,",
"3.25,4,1,1,2,KEY_X,",
"4.25,4,1,1,3,KEY_C,",
"5.25,4,1,1,4,KEY_V,",
"6.25,4,1,1,5,KEY_B,",
"7.25,4,1,6,4,KEY_N,",
"8.25,4,1,6,14,KEY_M,",
"9.25,4,1,7,14,KEY_COMMA,",
"10.25,4,1,7,4,KEY_PERIOD,",
"11.25,4,1,1,10,KEY_SLASH,",
"12.25,4,2.75,1,11,KEY_RIGHT_SHIFT,",
"16,4,1,1,7,KEY_UP,",
"18,4,1,1,6,KEYPAD_1,",
"19,4,1,1,7,KEYPAD_2,",
"20,4,1,1,8,KEYPAD_3,",
"21,4,0.5,0,9,KEYPAD_ENTER,",

"0,5,1.25,0,0,KEY_CTRL,",
"1.25,5,1.25,0,1,KEY_GUI,",
"2.5,5,1.25,0,2,KEY_ALT,",
"3.75,5,6.25,6,5,KEY_SPACE,",
"10,5,1.25,7,5,KEY_RIGHT_ALT,",
"11.25,5,1.25,0,11,KEY_RIGHT_GUI,",
"12.5,5,1.25,0,11,KEY_FN,",
"13.75,5,1.25,6,6,KEY_RIGHT_CTRL,",
"15,5,1,6,9,KEY_LEFT,",
"16,5,1,0,6,KEY_DOWN,",
"17,5,1,0,8,KEY_RIGHT,",
"18,5,2,0,6,KEYPAD_0,",
"20,5,1,0,8,KEYPAD_PERIOD,"
            };
        #endregion
    }
    public partial class QMK108_ISO
    {
        #region kecap
        string[] keycap = new string[108]{
"0,0,1,5,0,KEY_ESC,",
"2,0,1,5,2,KEY_F1,",
"3,0,1,5,3,KEY_F2,",
"4,0,1,5,4,KEY_F3,",
"5,0,1,5,5,KEY_F4,",
"6.5,0,1,6,0,KEY_F5,",
"7.5,0,1,6,10,KEY_F6,",
"8.5,0,1,7,10,KEY_F7,",
"9.5,0,1,7,0,KEY_F8,",
"11,0,1,5,11,KEY_F9,",
"12,0,1,5,12,KEY_F10,",
"13,0,1,5,13,KEY_F11,",
"14,0,1,5,14,KEY_F12,",
"15,0,1,0,13,KEY_PRINTSCREEN,",
"16,0,1,7,6,KEY_SCROLL_LOCK,",
"17,0,1,7,9,KEY_PAUSE,",
"18,0,1,5,14,MACRO0,",
"19,0,1,0,13,MACRO1,",
"20,0,1,7,6,MACRO5,",
"21,0,1,7,9,MACRO3,",

"0,1,1,4,0,KEY_TILDE,",
"1,1,1,4,1,KEY_1,",
"2,1,1,4,2,KEY_2,",
"3,1,1,4,3,KEY_3,",
"4,1,1,4,4,KEY_4,",
"5,1,1,4,5,KEY_5,",
"6,1,1,6,1,KEY_6,",
"7,1,1,6,11,KEY_7,",
"8,1,1,7,11,KEY_8,",
"9,1,1,7,1,KEY_9,",
"10,1,1,4,10,KEY_0,",
"11,1,1,4,11,KEY_MINUS,",
"12,1,1,4,12,KEY_EQUAL,",
"13,1,2,4,14,KEY_BACKSPACE,",
"15,1,1,4,6,KEY_INSERT,",
"16,1,1,4,7,KEY_HOME,",
"17,1,1,4,8,KEY_PAGE_UP,",
"18,1,1,4,14,KEY_NUM_LOCK,",
"19,1,1,4,6,KEYPAD_SLASH,",
"20,1,1,4,7,KEYPAD_ASTERIX,",
"21,1,1,4,8,KEYPAD_MINUS,",
"0,2,1.5,3,0,KEY_TAB,",
"1.5,2,1,3,1,KEY_Q,",
"2.5,2,1,3,2,KEY_W,",
"3.5,2,1,3,3,KEY_E,",
"4.5,2,1,3,4,KEY_R,",
"5.5,2,1,3,5,KEY_T,",
"6.5,2,1,6,2,KEY_Y,",
"7.5,2,1,6,12,KEY_U,",
"8.5,2,1,7,12,KEY_I,",
"9.5,2,1,7,2,KEY_O,",
"10.5,2,1,3,10,KEY_P,",
"11.5,2,1,3,11,KEY_LEFT_BRACE,",
"12.5,2,1,3,12,KEY_RIGHT_BRACE,",
"13.5,2,1.5,3,13,KEY_BACKSLASH,",
"15,2,1,3,6,KEY_DELETE,",
"16,2,1,3,7,KEY_END,",
"17,2,1,3,8,KEY_PAGE_DOWN,",
"18,2,1,3,6,KEYPAD_7,",
"19,2,1,3,7,KEYPAD_8,",
"20,2,1,3,8,KEYPAD_9,",
"21,2,0.5,2,9,KEYPAD_PLUS,",

"0,3,1.75,2,0,KEY_CAPS_LOCK,",
"1.75,3,1,2,1,KEY_A,",
"2.75,3,1,2,2,KEY_S,",
"3.75,3,1,2,3,KEY_D,",
"4.75,3,1,2,4,KEY_F,",
"5.75,3,1,2,5,KEY_G,",
"6.75,3,1,6,3,KEY_H,",
"7.75,3,1,6,13,KEY_J,",
"8.75,3,1,7,13,KEY_K,",
"9.75,3,1,7,3,KEY_L,",
"10.75,3,1,2,10,KEY_SEMICOLON,",
"11.75,3,1,2,11,KEY_QUOTE,",
"12.75,3,2.25,2,13,KEY_ENTER,",
"18,3,1,2,6,KEYPAD_4,",
"19,3,1,2,7,KEYPAD_5,",
"20,3,1,2,8,KEYPAD_6,",

"0,4,2.25,1,0,KEY_SHIFT,",
"2.25,4,1,1,1,KEY_Z,",
"3.25,4,1,1,2,KEY_X,",
"4.25,4,1,1,3,KEY_C,",
"5.25,4,1,1,4,KEY_V,",
"6.25,4,1,1,5,KEY_B,",
"7.25,4,1,6,4,KEY_N,",
"8.25,4,1,6,14,KEY_M,",
"9.25,4,1,7,14,KEY_COMMA,",
"10.25,4,1,7,4,KEY_PERIOD,",
"11.25,4,1,1,10,KEY_SLASH,",
"12.25,4,2.75,1,11,KEY_RIGHT_SHIFT,",
"16,4,1,1,7,KEY_UP,",
"18,4,1,1,6,KEYPAD_1,",
"19,4,1,1,7,KEYPAD_2,",
"20,4,1,1,8,KEYPAD_3,",
"21,4,0.5,0,9,KEYPAD_ENTER,",

"0,5,1.25,0,0,KEY_CTRL,",
"1.25,5,1.25,0,1,KEY_GUI,",
"2.5,5,1.25,0,2,KEY_ALT,",
"3.75,5,6.25,6,5,KEY_SPACE,",
"10,5,1.25,7,5,KEY_RIGHT_ALT,",
"11.25,5,1.25,0,11,KEY_RIGHT_GUI,",
"12.5,5,1.25,0,11,KEY_FN,",
"13.75,5,1.25,6,6,KEY_RIGHT_CTRL,",
"15,5,1,6,9,KEY_LEFT,",
"16,5,1,0,6,KEY_DOWN,",
"17,5,1,0,8,KEY_RIGHT,",
"18,5,2,0,6,KEYPAD_0,",
"20,5,1,0,8,KEYPAD_PERIOD,"
            };
        #endregion
    }
}

