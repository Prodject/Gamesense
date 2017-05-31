namespace Gamesense
{
	public class Constants
	{
		// === DEVICE TYPES ===================================================================================
		public const string DEVICE_TYPE_KEYBOARD = "keyboard";
		public const string DEVICE_TYPE_MOUSE = "mouse";
		public const string DEVICE_TYPE_HEADSET = "headset";
		public const string DEVICE_TYPE_INDICATOR = "indicator";
		public const string DEVICE_TYPE_TACTILE = "tactile";
		public const string DEVICE_TYPE_RGB1ZONE = "rgb-1-zone";
		public const string DEVICE_TYPE_RGB2ZONE = "rgb-2-zone";
		public const string DEVICE_TYPE_RGB3ZONE = "rgb-3-zone";
		public const string DEVICE_TYPE_RGB4ZONE = "rgb-4-zone";
		public const string DEVICE_TYPE_RGB5ZONE = "rgb-5-zone";
		public const string DEVICE_TYPE_PERKEY = "rbg-per-key-zone";
		public const string DEVICE_TYPE_SCREENED = "screened";
		public const string DEVICE_TYPE_SCREENED_WXH = "screened-{0}x{1}";  // Can also use the GET_DEVICE_TYPE_SCREENED_WXH method

		// === ILLUMINTATION MODES ============================================================================
		public const string ILLUMINATION_MODE_COLOR = "color";              // All LEDs in the zone are set to the computed color
		public const string ILLUMINATION_MODE_PERCENT = "percent";          // The LEDs are used to create a visualization of the control value (as a percentage) by illuminating them proportionally and leaving the rest black/off.
		public const string ILLUMINATION_MODE_COUNT = "count";              // As above, but the number of LEDs illuminated directly correspond to the control value. I.e. if the value is 2, 2 LEDs will be lit.
		public const string VIBRATE_MODE = "vibrate";

		// === ZONES ==========================================================================================
		public const string ZONE_KEYBOARD_FKEYS = "function-keys";          // F1 - F12
		public const string ZONE_KEYBOARD_MAIN = "main-keyboard";           // All keys included in the central keyboard area
		public const string ZONE_KEYBOARD_KEYPAD = "keypad";                // All keys in the numpad cluster
		public const string ZONE_KEYBOARD_NUMKEYS = "number-keys";          // 1 - 0 on the main keyboard area
		public const string ZONE_KEYBOARD_MACRO = "macro-keys";             // Macro keys on the left side of the keyboard

		public const string ZONE_MOUSE_WHEEL = "wheel";
		public const string ZONE_MOUSE_LOGO = "logo";
		public const string ZONE_MOUSE_BASE = "base";                       // Base station led (Sensei Wireless)

		public const string ZONE_TACTILE_ONE = "one";                       // Rival 700

		public const string ZONE_RGB1_ONE = "one";
		public const string ZONE_RGB2_ONE = "one";
		public const string ZONE_RGB2_TWO = "two";
		public const string ZONE_RGB3_ONE = "one";
		public const string ZONE_RGB3_TWO = "two";
		public const string ZONE_RGB3_THREE = "three";
		public const string ZONE_RGB4_ONE = "one";
		public const string ZONE_RGB4_TWO = "two";
		public const string ZONE_RGB4_THREE = "three";
		public const string ZONE_RGB4_FOUR = "four";
		public const string ZONE_RGB5_ONE = "one";
		public const string ZONE_RGB5_TWO = "two";
		public const string ZONE_RGB5_THREE = "three";
		public const string ZONE_RGB5_FOUR = "four";
		public const string ZONE_RGB5_FIVE = "five";

		public const string ZONE_SCREENED_ONE = "one";

		public const string ZONE_PER_KEY_LOGO = "logo";                     // SS logo in the top right corner
		public const string ZONE_PER_KEY_A = "a";
		public const string ZONE_PER_KEY_B = "b";
		public const string ZONE_PER_KEY_C = "c";
		public const string ZONE_PER_KEY_D = "d";
		public const string ZONE_PER_KEY_E = "e";
		public const string ZONE_PER_KEY_F = "f";
		public const string ZONE_PER_KEY_G = "g";
		public const string ZONE_PER_KEY_H = "h";
		public const string ZONE_PER_KEY_I = "i";
		public const string ZONE_PER_KEY_J = "j";
		public const string ZONE_PER_KEY_K = "k";
		public const string ZONE_PER_KEY_L = "l";
		public const string ZONE_PER_KEY_M = "m";
		public const string ZONE_PER_KEY_N = "n";
		public const string ZONE_PER_KEY_O = "o";
		public const string ZONE_PER_KEY_P = "p";
		public const string ZONE_PER_KEY_Q = "q";
		public const string ZONE_PER_KEY_R = "r";
		public const string ZONE_PER_KEY_S = "s";
		public const string ZONE_PER_KEY_T = "t";
		public const string ZONE_PER_KEY_U = "u";
		public const string ZONE_PER_KEY_V = "v";
		public const string ZONE_PER_KEY_W = "w";
		public const string ZONE_PER_KEY_X = "x";
		public const string ZONE_PER_KEY_Y = "y";
		public const string ZONE_PER_KEY_Z = "z";
		public const string ZONE_PER_KEY_KB0 = "keyboard-0";
		public const string ZONE_PER_KEY_KB1 = "keyboard-1";
		public const string ZONE_PER_KEY_KB2 = "keyboard-2";
		public const string ZONE_PER_KEY_KB3 = "keyboard-3";
		public const string ZONE_PER_KEY_KB4 = "keyboard-4";
		public const string ZONE_PER_KEY_KB5 = "keyboard-5";
		public const string ZONE_PER_KEY_KB6 = "keyboard-6";
		public const string ZONE_PER_KEY_KB7 = "keyboard-7";
		public const string ZONE_PER_KEY_KB8 = "keyboard-8";
		public const string ZONE_PER_KEY_KB9 = "keyboard-9";
		public const string ZONE_PER_KEY_RETURN = "return";
		public const string ZONE_PER_KEY_ESCAPE = "escape";
		public const string ZONE_PER_KEY_BACKSPACE = "backspace";
		public const string ZONE_PER_KEY_TAB = "tab";
		public const string ZONE_PER_KEY_SPACEBAR = "spacebar";
		public const string ZONE_PER_KEY_CAPS = "caps";
		public const string ZONE_PER_KEY_DASH = "dash";
		public const string ZONE_PER_KEY_EQUAL = "equal";
		public const string ZONE_PER_KEY_LBRACKET = "l-bracket";
		public const string ZONE_PER_KEY_RBRACKET = "r-bracket";
		public const string ZONE_PER_KEY_BACKSLASH = "backslash";
		public const string ZONE_PER_KEY_POUND = "pound"; //# not £
		public const string ZONE_PER_KEY_SEMICOLON = "semicolon";
		public const string ZONE_PER_KEY_QUOTE = "quote";
		public const string ZONE_PER_KEY_BACKQUOTE = "backquote";
		public const string ZONE_PER_KEY_COMMA = "comma";
		public const string ZONE_PER_KEY_PERIOD = "period";
		public const string ZONE_PER_KEY_SLASH = "slash";
		public const string ZONE_PER_KEY_F1 = "f1";
		public const string ZONE_PER_KEY_F2 = "f2";
		public const string ZONE_PER_KEY_F3 = "f3";
		public const string ZONE_PER_KEY_F4 = "f4";
		public const string ZONE_PER_KEY_F5 = "f5";
		public const string ZONE_PER_KEY_F6 = "f6";
		public const string ZONE_PER_KEY_F7 = "f7";
		public const string ZONE_PER_KEY_F8 = "f8";
		public const string ZONE_PER_KEY_F9 = "f9";
		public const string ZONE_PER_KEY_F10 = "f10";
		public const string ZONE_PER_KEY_F11 = "f11";
		public const string ZONE_PER_KEY_F12 = "f12";
		public const string ZONE_PER_KEY_PRINTSCREEN = "printscreen";
		public const string ZONE_PER_KEY_SCROLLLOCK = "scrolllock";
		public const string ZONE_PER_KEY_PAUSE = "pause";
		public const string ZONE_PER_KEY_INSERT = "insert";
		public const string ZONE_PER_KEY_HOME = "home";
		public const string ZONE_PER_KEY_PAGEUP = "pageup";
		public const string ZONE_PER_KEY_PAGEDOWN = "pagedown";
		public const string ZONE_PER_KEY_DELETE = "delete";
		public const string ZONE_PER_KEY_END = "end";
		public const string ZONE_PER_KEY_ARROWUP = "uparrow";
		public const string ZONE_PER_KEY_ARROWDOWN = "downarrow";
		public const string ZONE_PER_KEY_ARROWLEFT = "leftarrow";
		public const string ZONE_PER_KEY_ARROWRIGHT = "rightarrow";
		public const string ZONE_PER_KEY_NUMPAD_NUMLOCK = "keypad-num-lock";
		public const string ZONE_PER_KEY_NUMPAD_DIVIDE = "keypad-divide";
		public const string ZONE_PER_KEY_NUMPAD_TIMES = "keypad-times";
		public const string ZONE_PER_KEY_NUMPAD_MINUS = "keypad-minus";
		public const string ZONE_PER_KEY_NUMPAD_PLUS = "keypad-plus";
		public const string ZONE_PER_KEY_NUMPAD_ENTER = "keypad-enter";
		public const string ZONE_PER_KEY_NUMPAD_PERIOD = "keypad-period";
		public const string ZONE_PER_KEY_NUMPAD_0 = "keypad-0";
		public const string ZONE_PER_KEY_NUMPAD_1 = "keypad-1";
		public const string ZONE_PER_KEY_NUMPAD_2 = "keypad-2";
		public const string ZONE_PER_KEY_NUMPAD_3 = "keypad-3";
		public const string ZONE_PER_KEY_NUMPAD_4 = "keypad-4";
		public const string ZONE_PER_KEY_NUMPAD_5 = "keypad-5";
		public const string ZONE_PER_KEY_NUMPAD_6 = "keypad-6";
		public const string ZONE_PER_KEY_NUMPAD_7 = "keypad-7";
		public const string ZONE_PER_KEY_NUMPAD_8 = "keypad-8";
		public const string ZONE_PER_KEY_NUMPAD_9 = "keypad-9";
		public const string ZONE_PER_KEY_LCTRL = "l-ctrl";
		public const string ZONE_PER_KEY_LSHIFT = "l-shift";
		public const string ZONE_PER_KEY_LALT = "l-alt";
		public const string ZONE_PER_KEY_LWIN = "l-win";
		public const string ZONE_PER_KEY_RCTRL = "r-ctrl";
		public const string ZONE_PER_KEY_RSHIFT = "r-shift";
		public const string ZONE_PER_KEY_RALT = "r-alt";
		public const string ZONE_PER_KEY_RWIN = "r-win";
		public const string ZONE_PER_KEY_SSKEY = "ss-key";                       // SteelSeries key
		public const string ZONE_PER_KEY_WINMENU = "win-menu";                   // Application button (right of the SS key)
		public const string ZONE_PER_KEY_MACRO0 = "m0";
		public const string ZONE_PER_KEY_MACRO1 = "m1";
		public const string ZONE_PER_KEY_MACRO2 = "m2";
		public const string ZONE_PER_KEY_MACRO3 = "m3";
		public const string ZONE_PER_KEY_MACRO4 = "m4";
		public const string ZONE_PER_KEY_MACRO5 = "m5";

		public static string GET_DEVICE_TYPE_SCREENED_WXH(int width, int height)
		{
			return string.Format(DEVICE_TYPE_SCREENED_WXH, width, height);
		}
	}

	public class TactilePresets
	{
		public const string STRONGCLICK_30 = "ti_predefined_strongclick_30";
		public const string STRONGCLICK_60 = "ti_predefined_strongclick_60";
		public const string STRONGCLICK_100 = "ti_predefined_strongclick_100";

		public const string SHARPCLICK_30 = "ti_predefined_sharpclick_30";
		public const string SHARPCLICK_60 = "ti_predefined_sharpclick_60";
		public const string SHARPCLICK_100 = "ti_predefined_sharpclick_100";

		public const string SOFTBUMP_30 = "ti_predefined_softbump_30";
		public const string SOFTBUMP_60 = "ti_predefined_softbump_60";
		public const string SOFTBUMP_100 = "ti_predefined_softbump_100";

		public const string DOUBLECLICK_60 = "ti_predefined_doubleclick_60";
		public const string DOUBLECLICK_100 = "ti_predefined_doubleclick_100";

		public const string TRIPLECLICK = "ti_predefined_tripleclick_100";

		public const string SOFTFUZZ = "ti_predefined_softfuzz_60";

		public const string STRONGBUZZ = "ti_predefined_strongbuzz_100";

		public const string BUZZALERT750MS = "ti_predefined_buzzalert750ms";
		public const string BUZZALERT1000MS = "ti_predefined_buzzalert1000ms";

		public const string STRONGCLICK2_30 = "ti_predefined_strongclick4_30";
		public const string STRONGCLICK2_60 = "ti_predefined_strongclick3_60";
		public const string STRONGCLICK2_80 = "ti_predefined_strongclick2_80";
		public const string STRONGCLICK2_100 = "ti_predefined_strongclick1_100";

		public const string MEDIUMCLICK_60 = "ti_predefined_mediumclick3_60";
		public const string MEDIUMCLICK_80 = "ti_predefined_mediumclick2_80";
		public const string MEDIUMCLICK_100 = "ti_predefined_mediumclick1_100";

		public const string SHARPTICK_60 = "ti_predefined_sharptick3_60";
		public const string SHARPTICK_80 = "ti_predefined_sharptick2_80";
		public const string SHARPTICK_100 = "ti_predefined_sharptick1_100";

		public const string SHORTDOUBLECLICKSTRONG_30 = "ti_predefined_shortdoubleclickstrong4_30";
		public const string SHORTDOUBLECLICKSTRONG_60 = "ti_predefined_shortdoubleclickstrong3_60";
		public const string SHORTDOUBLECLICKSTRONG_80 = "ti_predefined_shortdoubleclickstrong2_80";
		public const string SHORTDOUBLECLICKSTRONG_100 = "ti_predefined_shortdoubleclickstrong1_100";

		public const string SHORTDOUBLECLICKMEDIUM_60 = "ti_predefined_shortdoubleclickmedium3_60";
		public const string SHORTDOUBLECLICKMEDIUM_80 = "ti_predefined_shortdoubleclickmedium2_80";
		public const string SHORTDOUBLECLICKMEDIUM_100 = "ti_predefined_shortdoubleclickmedium1_100";

		public const string SHORTDOUBLESHARPTICK_60 = "ti_predefined_shortdoublesharptick3_60";
		public const string SHORTDOUBLESHARPTICK_80 = "ti_predefined_shortdoublesharptick2_80";
		public const string SHORTDOUBLESHARPTICK_100 = "ti_predefined_shortdoublesharptick1_100";

		public const string LONGDOUBLESHARPCLICKSTRONG_30 = "ti_predefined_longdoublesharpclickstrong4_30";
		public const string LONGDOUBLESHARPCLICKSTRONG_60 = "ti_predefined_longdoublesharpclickstrong3_60";
		public const string LONGDOUBLESHARPCLICKSTRONG_80 = "ti_predefined_longdoublesharpclickstrong2_80";
		public const string LONGDOUBLESHARPCLICKSTRONG_100 = "ti_predefined_longdoublesharpclickstrong1_100";

		public const string LONGDOUBLESHARPCLICKMEDIUM_60 = "ti_predefined_longdoublesharpclickmedium3_60";
		public const string LONGDOUBLESHARPCLICKMEDIUM_80 = "ti_predefined_longdoublesharpclickmedium2_80";
		public const string LONGDOUBLESHARPCLICKMEDIUM_100 = "ti_predefined_longdoublesharpclickmedium1_100";

		public const string LONGDOUBLESHARPTICK_60 = "ti_predefined_longdoublesharptick3_60";
		public const string LONGDOUBLESHARPTICK_80 = "ti_predefined_longdoublesharptick2_80";
		public const string LONGDOUBLESHARPTICK_100 = "ti_predefined_longdoublesharptick1_100";

		public const string BUZZ_20 = "ti_predefined_buzz5_20";
		public const string BUZZ_40 = "ti_predefined_buzz4_40";
		public const string BUZZ_60 = "ti_predefined_buzz3_60";
		public const string BUZZ_80 = "ti_predefined_buzz2_80";
		public const string BUZZ_100 = "ti_predefined_buzz1_100";

		public const string PULSINGSTRONG_60 = "ti_predefined_pulsingstrong2_60";
		public const string PULSINGSTRONG_100 = "ti_predefined_pulsingstrong1_100";

		public const string PULSINGMEDIUM_60 = "ti_predefined_pulsingmedium2_60";
		public const string PULSINGMEDIUM_100 = "ti_predefined_pulsingmedium1_100";

		public const string PULSINGSHARP_60 = "ti_predefined_pulsingsharp2_60";
		public const string PULSINGSHARP_100 = "ti_predefined_pulsingsharp1_100";

		public const string TRANSITIONCLICK_10 = "ti_predefined_transitionclick6_10";
		public const string TRANSITIONCLICK_20 = "ti_predefined_transitionclick5_20";
		public const string TRANSITIONCLICK_40 = "ti_predefined_transitionclick4_40";
		public const string TRANSITIONCLICK_60 = "ti_predefined_transitionclick3_60";
		public const string TRANSITIONCLICK_80 = "ti_predefined_transitionclick2_80";
		public const string TRANSITIONCLICK_100 = "ti_predefined_transitionclick1_100";

		public const string TRANSITIONHUM_10 = "ti_predefined_transitionhum6_10";
		public const string TRANSITIONHUM_20 = "ti_predefined_transitionhum5_20";
		public const string TRANSITIONHUM_40 = "ti_predefined_transitionhum4_40";
		public const string TRANSITIONHUM_60 = "ti_predefined_transitionhum3_60";
		public const string TRANSITIONHUM_80 = "ti_predefined_transitionhum2_80";
		public const string TRANSITIONHUM_100 = "ti_predefined_transitionhum1_100";

		public const string TRANSITIONRAMPDOWNLONGSMOOTH1_100TO0 = "ti_predefined_transitionrampdownlongsmooth1_100to0";
		public const string TRANSITIONRAMPDOWNLONGSMOOTH2_100TO0 = "ti_predefined_transitionrampdownlongsmooth2_100to0";

		public const string TRANSITIONRAMPDOWNMEDIUMSMOOTH1_100TO0 = "ti_predefined_transitionrampdownmediumsmooth1_100to0";
		public const string TRANSITIONRAMPDOWNMEDIUMSMOOTH2_100TO0 = "ti_predefined_transitionrampdownmediumsmooth2_100to0";

		public const string TRANSITIONRAMPDOWNSHORTSMOOTH1_100TO0 = "ti_predefined_transitionrampdownshortsmooth1_100to0";
		public const string TRANSITIONRAMPDOWNSHORTSMOOTH2_100TO0 = "ti_predefined_transitionrampdownshortsmooth2_100to0";

		public const string TRANSITIONRAMPDOWNLONGSHARP1_100TO0 = "ti_predefined_transitionrampdownlongsharp1_100to0";
		public const string TRANSITIONRAMPDOWNLONGSHARP2_100TO0 = "ti_predefined_transitionrampdownlongsharp2_100to0";

		public const string TRANSITIONRAMPDOWNMEDIUMSHARP1_100TO0 = "ti_predefined_transitionrampdownmediumsharp1_100to0";
		public const string TRANSITIONRAMPDOWNMEDIUMSHARP2_100TO0 = "ti_predefined_transitionrampdownmediumsharp2_100to0";

		public const string TRANSITIONRAMPDOWNSHORTSHARP1_100TO0 = "ti_predefined_transitionrampdownshortsharp1_100to0";
		public const string TRANSITIONRAMPDOWNSHORTSHARP2_100TO0 = "ti_predefined_transitionrampdownshortsharp2_100to0";

		public const string TRANSITIONRAMP_TRANSITIONRAMPUPLONGSMOOTH1_0TO100 = "ti_predefined_transitionrampuplongsmooth1_0to100";
		public const string TRANSITIONRAMP_TRANSITIONRAMPUPLONGSMOOTH2_0TO100 = "ti_predefined_transitionrampuplongsmooth2_0to100";

		public const string TRANSITIONRAMP_TRANSITIONRAMPUPMEDIUMSMOOTH1_0TO100 = "ti_predefined_transitionrampupmediumsmooth1_0to100";
		public const string TRANSITIONRAMP_TRANSITIONRAMPUPMEDIUMSMOOTH2_0TO100 = "ti_predefined_transitionrampupmediumsmooth2_0to100";

		public const string TRANSITIONRAMP_TRANSITIONRAMPUPSHORTSMOOTH1_0TO100 = "ti_predefined_transitionrampupshortsmooth1_0to100";
		public const string TRANSITIONRAMP_TRANSITIONRAMPUPSHORTSMOOTH2_0TO100 = "ti_predefined_transitionrampupshortsmooth2_0to100";

		public const string TRANSITIONRAMP_TRANSITIONRAMPUPLONGSHARP1_0TO100 = "ti_predefined_transitionrampuplongsharp1_0to100";
		public const string TRANSITIONRAMP_TRANSITIONRAMPUPLONGSHARP2_0TO100 = "ti_predefined_transitionrampuplongsharp2_0to100";

		public const string TRANSITIONRAMP_TRANSITIONRAMPUPMEDIUMSHARP1_0TO100 = "ti_predefined_transitionrampupmediumsharp1_0to100";
		public const string TRANSITIONRAMP_TRANSITIONRAMPUPMEDIUMSHARP2_0TO100 = "ti_predefined_transitionrampupmediumsharp2_0to100";

		public const string TRANSITIONRAMP_TRANSITIONRAMPUPSHORTSHARP1_0TO100 = "ti_predefined_transitionrampupshortsharp1_0to100";
		public const string TRANSITIONRAMP_TRANSITIONRAMPUPSHORTSHARP2_0TO100 = "ti_predefined_transitionrampupshortsharp2_0to100";

		public const string TRANSITIONRAMP_TRANSITIONRAMPDOWNLONGSMOOTH1_50TO0 = "ti_predefined_transitionrampdownlongsmooth1_50to0";
		public const string TRANSITIONRAMP_TRANSITIONRAMPDOWNLONGSMOOTH2_50TO0 = "ti_predefined_transitionrampdownlongsmooth2_50to0";

		public const string TRANSITIONRAMP_TRANSITIONRAMPDOWNMEDIUMSMOOTH1_50TO0 = "ti_predefined_transitionrampdownmediumsmooth1_50to0";
		public const string TRANSITIONRAMP_TRANSITIONRAMPDOWNMEDIUMSMOOTH2_50TO0 = "ti_predefined_transitionrampdownmediumsmooth2_50to0";

		public const string TRANSITIONRAMP_TRANSITIONRAMPDOWNSHORTSMOOTH1_50TO0 = "ti_predefined_transitionrampdownshortsmooth1_50to0";
		public const string TRANSITIONRAMP_TRANSITIONRAMPDOWNSHORTSMOOTH2_50TO0 = "ti_predefined_transitionrampdownshortsmooth2_50to0";

		public const string TRANSITIONRAMP_TRANSITIONRAMPDOWNLONGSHARP1_50TO0 = "ti_predefined_transitionrampdownlongsharp1_50to0";
		public const string TRANSITIONRAMP_TRANSITIONRAMPDOWNLONGSHARP2_50TO0 = "ti_predefined_transitionrampdownlongsharp2_50to0";

		public const string TRANSITIONRAMP_TRANSITIONRAMPDOWNMEDIUMSHARP1_50TO0 = "ti_predefined_transitionrampdownmediumsharp1_50to0";
		public const string TRANSITIONRAMP_TRANSITIONRAMPDOWNMEDIUMSHARP2_50TO0 = "ti_predefined_transitionrampdownmediumsharp2_50to0";

		public const string TRANSITIONRAMP_TRANSITIONRAMPDOWNSHORTSHARP1_50TO0 = "ti_predefined_transitionrampdownshortsharp1_50to0";
		public const string TRANSITIONRAMP_TRANSITIONRAMPDOWNSHORTSHARP2_50TO0 = "ti_predefined_transitionrampdownshortsharp2_50to0";

		public const string TRANSITIONRAMP_TRANSITIONRAMPUPLONGSMOOTH1_0TO50 = "ti_predefined_transitionrampuplongsmooth1_0to50";
		public const string TRANSITIONRAMP_TRANSITIONRAMPUPLONGSMOOTH2_0TO50 = "ti_predefined_transitionrampuplongsmooth2_0to50";

		public const string TRANSITIONRAMP_TRANSITIONRAMPUPMEDIUMSMOOTH1_0TO50 = "ti_predefined_transitionrampupmediumsmooth1_0to50";
		public const string TRANSITIONRAMP_TRANSITIONRAMPUPMEDIUMSMOOTH2_0TO50 = "ti_predefined_transitionrampupmediumsmooth2_0to50";

		public const string TRANSITIONRAMP_TRANSITIONRAMPUPSHORTSMOOTH1_0TO50 = "ti_predefined_transitionrampupshortsmooth1_0to50";
		public const string TRANSITIONRAMP_TRANSITIONRAMPUPSHORTSMOOTH2_0TO50 = "ti_predefined_transitionrampupshortsmooth2_0to50";

		public const string TRANSITIONRAMP_TRANSITIONRAMPUPLONGSHARP1_0TO50 = "ti_predefined_transitionrampuplongsharp1_0to50";
		public const string TRANSITIONRAMP_TRANSITIONRAMPUPLONGSHARP2_0TO50 = "ti_predefined_transitionrampuplongsharp2_0to50";

		public const string TRANSITIONRAMP_TRANSITIONRAMPUPMEDIUMSHARP1_0TO50 = "ti_predefined_transitionrampupmediumsharp1_0to50";
		public const string TRANSITIONRAMP_TRANSITIONRAMPUPMEDIUMSHARP2_0TO50 = "ti_predefined_transitionrampupmediumsharp2_0to50";

		public const string TRANSITIONRAMP_TRANSITIONRAMPUPSHORTSHARP1_0TO50 = "ti_predefined_transitionrampupshortsharp1_0to50";
		public const string TRANSITIONRAMP_TRANSITIONRAMPUPSHORTSHARP2_0TO50 = "ti_predefined_transitionrampupshortsharp2_0to50";

		public const string TRANSITIONRAMP_LONGBUZZFORPROGRAMMATICSTOPPING_100 = "ti_predefined_longbuzzforprogrammaticstopping_100";

		public const string TRANSITIONRAMP_SMOOTHHUM5NOKICKORBRAKEPULSE_10 = "ti_predefined_smoothhum5nokickorbrakepulse_10";
		public const string TRANSITIONRAMP_SMOOTHHUM5NOKICKORBRAKEPULSE_20 = "ti_predefined_smoothhum4nokickorbrakepulse_20";
		public const string TRANSITIONRAMP_SMOOTHHUM5NOKICKORBRAKEPULSE_30 = "ti_predefined_smoothhum3nokickorbrakepulse_30";
		public const string TRANSITIONRAMP_SMOOTHHUM5NOKICKORBRAKEPULSE_40 = "ti_predefined_smoothhum2nokickorbrakepulse_40";
		public const string TRANSITIONRAMP_SMOOTHHUM5NOKICKORBRAKEPULSE_50 = "ti_predefined_smoothhum1nokickorbrakepulse_50";
	}

	public enum IconColor { Orange, Gold, Yellow, Green, Teal, Light_Blue, Blue, Purple, Fuschia, Pink, Red, Silver }
	public enum EventIcon { None, Health, Armor, Ammo, Money, Explosion, Skull, Headshot, Helmet, Hunger, Bubbles, Compass, Pickaxe, Potion, Clock, Lightning, Backpack }
}
