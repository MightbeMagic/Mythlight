using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// 'Tags' are item tags used for searchign and sorting items. Any item can have any combination of tags - this file is merely sorted to common uses of them.
    /// Due to the likelyhood that the tags list will expand often, it is recommended any feature referencing this enum should do so dynamically if possible.
    /// </summary>
    public enum Tag 
    {
        //special
        posable,
        pallete,
        dyable,

        //hair
        Ponytail,
        Long,
        Short,
        Bun,
        Spacebun,

        //tops
        LongSleeve,
        ShortSleeve,
        ButtonUp,
        Tshirt,
        blouse,
        camisole,
        cardigan,
        cropped,
        hoodie,
        peasant,
        polo,
        tubetop,
        tunic,

        //bottoms
        Miniskirt,
        skirt,
        pants,
        jeans,
        shorts,
        maxi,
        cargo,

        //outfit or both top/bottom
        gown,
        dress,
        strapless,
        shift,
        slip,
        bubble,
        sundress,
        bikini,
        lingere,
        jumpsuit,
        jumper,
        aline,
        kimono,
        tuxedo,

        //accesories
        crown,
        hat,
        horns,
        earring,
        wings,
        tail,
        weapon,
        belt,

        //neck
        bow,
        necklace,
        tie,

        //makeup

        //theme
        royal,
        lolita,
        ouji,
        scifi,
        fantasy,
        medival,
        gothic,
        creature,
        evening,
        wedding,

        //cultural

        //color
        red,
        orange,
        yellow,
        green,
        blue,
        violet,
        black,
        white,
        grey,
        tan,
        khaki,
        gold,
        silver

    }
}