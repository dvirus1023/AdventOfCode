﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace AdventOfCode
{
    class DayFive
    {
        static List<string> input = new List<string>() { "zgsnvdmlfuplrubt", "vlhagaovgqjmgvwq", "ffumlmqwfcsyqpss", "zztdcqzqddaazdjp", "eavfzjajkjesnlsb", "urrvucyrzzzooxhx", "xdwduffwgcptfwad", "orbryxwrmvkrsxsr", "jzfeybjlgqikjcow", "mayoqiswqqryvqdi", "iiyrkoujhgpgkcvx", "egcgupjkqwfiwsjl", "zbgtglaqqolttgng", "eytquncjituzzhsx", "dtfkgggvqadhqbwb", "zettygjpcoedwyio", "rwgwbwzebsnjmtln", "esbplxhvzzgawctn", "vnvshqgmbotvoine", "wflxwmvbhflkqxvo", "twdjikcgtpvlctte", "minfkyocskvgubvm", "sfxhhdhaopajbzof", "sofkjdtalvhgwpql", "uqfpeauqzumccnrc", "tdflsbtiiepijanf", "dhfespzrhecigzqb", "xobfthcuuzhvhzpn", "olgjglxaotocvrhw", "jhkzpfcskutwlwge", "zurkakkkpchzxjhq", "hekxiofhalvmmkdl", "azvxuwwfmjdpjskj", "arsvmfznblsqngvb", "ldhkzhejofreaucc", "adrphwlkehqkrdmo", "wmveqrezfkaivvaw", "iyphmphgntinfezg", "blomkvgslfnvspem", "cgpaqjvzhbumckwo", "ydhqjcuotkeyurpx", "sbtzboxypnmdaefr", "vxrkhvglynljgqrg", "ttgrkjjrxnxherxd", "hinyfrjdiwytetkw", "sufltffwqbugmozk", "tohmqlzxxqzinwxr", "jbqkhxfokaljgrlg", "fvjeprbxyjemyvuq", "gmlondgqmlselwah", "ubpwixgxdloqnvjp", "lxjfhihcsajxtomj", "qouairhvrgpjorgh", "nloszcwcxgullvxb", "myhsndsttanohnjn", "zjvivcgtjwenyilz", "qaqlyoyouotsmamm", "tadsdceadifqthag", "mafgrbmdhpnlbnks", "aohjxahenxaermrq", "ovvqestjhbuhrwlr", "lnakerdnvequfnqb", "agwpwsgjrtcjjikz", "lhlysrshsmzryzes", "xopwzoaqtlukwwdu", "xsmfrfteyddrqufn", "ohnxbykuvvlbbxpf", "bbdlivmchvzfuhoc", "vtacidimfcfyobhf", "tinyzzddgcnmiabd", "tcjzxftqcqrivqhn", "vgnduqyfpokbmzim", "revkvaxnsxospyow", "ydpgwxxoxlywxcgi", "wzuxupbzlpzmikel", "nscghlafavnsycjh", "xorwbquzmgmcapon", "asmtiycegeobfxrn", "eqjzvgkxgtlyuxok", "mmjrskloposgjoqu", "gceqosugbkvytfto", "khivvoxkvhrgwzjl", "qtmejuxbafroifjt", "ttmukbmpoagthtfl", "bxqkvuzdbehtduwv", "gvblrpzjylanoggj", "cltewhyjxdbmbtqj", "fbkgedqvomdipklj", "uxvuplhenqawfcjt", "fkdjmayiawdkycva", "gnloqfgbnibzyidh", "kyzorvtopjiyyyqg", "drckpekhpgrioblt", "tvhrkmbnpmkkrtki", "khaldwntissbijiz", "aoojqakosnaxosom", "xfptccznbgnpfyqw", "moqdwobwhjxhtrow", "chfwivedutskovri", "gprkyalfnpljcrmi", "pwyshpwjndasykst", "xuejivogihttzimd", "bugepxgpgahtsttl", "zufmkmuujavcskpq", "urybkdyvsrosrfro", "isjxqmlxwtqmulbg", "pxctldxgqjqhulgz", "hclsekryiwhqqhir", "hbuihpalwuidjpcq", "ejyqcxmfczqfhbxa", "xljdvbucuxnnaysv", "irqceqtqwemostbb", "anfziqtpqzqdttnz", "cgfklbljeneeqfub", "zudyqkuqqtdcpmuo", "iuvhylvznmhbkbgg", "mpgppmgfdzihulnd", "argwmgcvqqkxkrdi", "pdhrfvdldkfihlou", "cbvqnjrvrsnqzfob", "lkvovtsqanohzcmm", "vxoxjdyoylqcnyzt", "kurdpaqiaagiwjle", "gwklwnazaxfkuekn", "rbaamufphjsjhbdl", "tzbrvaqvizhsisbd", "pbcqlbfjvlideiub", "hiwoetbfywaeddtx", "fjirczxtuupfywyf", "omeoegeyyospreem", "ozbbpupqpsskvrjh", "pzvcxkvjdiyeyhxa", "odclumkenabcsfzr", "npdyqezqdjqaszvm", "yodkwzmrhtexfrqa", "rjcmmggjtactfrxz", "mioxfingsfoimual", "aqskaxjjborspfaa", "wientdsttkevjtkf", "tdaswkzckmxnfnct", "voucjhzvkkhuwoqk", "boaaruhalgaamqmh", "iufzxutxymorltvb", "pfbyvbayvnrpijpo", "obztirulgyfthgcg", "ntrenvhwxypgtjwy", "ephlkipjfnjfjrns", "pkjhurzbmobhszpx", "gqbnjvienzqfbzvj", "wjelolsrbginwnno", "votanpqpccxqricj", "bxyuyiglnmbtvehi", "qyophcjfknbcbjrb", "anoqkkbcdropskhj", "tcnyqaczcfffkrtl", "rsvqimuqbuddozrf", "meppxdrenexxksdt", "tyfhfiynzwadcord", "wayrnykevdmywycf", "mhowloqnppswyzbu", "tserychksuwrgkxz", "xycjvvsuaxsbrqal", "fkrdsgaoqdcqwlpn", "vrabcmlhuktigecp", "xgxtdsvpaymzhurx", "ciabcqymnchhsxkc", "eqxadalcxzocsgtr", "tsligrgsjtrnzrex", "qeqgmwipbspkbbfq", "vzkzsjujltnqwliw", "ldrohvodgbxokjxz", "jkoricsxhipcibrq", "qzquxawqmupeujrr", "mizpuwqyzkdbahvk", "suupfxbtoojqvdca", "ywfmuogvicpywpwm", "uevmznxmsxozhobl", "vjbyhsemwfwdxfxk", "iyouatgejvecmtin", "tcchwpuouypllcxe", "lgnacnphdiobdsef", "uoxjfzmdrmpojgbf", "lqbxsxbqqhpjhfxj", "knpwpcnnimyjlsyz", "fezotpoicsrshfnh", "dkiwkgpmhudghyhk", "yzptxekgldksridv", "pckmzqzyiyzdbcts", "oqshafncvftvwvsi", "yynihvdywxupqmbt", "iwmbeunfiuhjaaic", "pkpkrqjvgocvaxjs", "ieqspassuvquvlyz", "xshhahjaxjoqsjtl", "fxrrnaxlqezdcdvd", "pksrohfwlaqzpkdd", "ravytrdnbxvnnoyy", "atkwaifeobgztbgo", "inkcabgfdobyeeom", "ywpfwectajohqizp", "amcgorhxjcybbisv", "mbbwmnznhafsofvr", "wofcubucymnhuhrv", "mrsamnwvftzqcgta", "tlfyqoxmsiyzyvgv", "ydceguvgotylwtea", "btyvcjqhsygunvle", "usquiquspcdppqeq", "kifnymikhhehgote", "ybvkayvtdpgxfpyn", "oulxagvbavzmewnx", "tvvpekhnbhjskzpj", "azzxtstaevxurboa", "nfmwtfgrggmqyhdf", "ynyzypdmysfwyxgr", "iaobtgubrcyqrgmk", "uyxcauvpyzabbzgv", "fbasfnwiguasoedc", "mgmjoalkbvtljilq", "szgkxiqkufdvtksb", "xgfzborpavdmhiuj", "hmuiwnsonvfgcrva", "zolcffdtobfntifb", "mvzgcsortkugvqjr", "pbbpgraaldqvzwhs", "zvsxegchksgnhpuv", "kdpdboaxsuxfswhx", "jdfggigejfupabth", "tpeddioybqemyvqz", "mxsntwuesonybjby", "tzltdsiojfvocige", "ubtdrneozoejiqrv", "fusyucnhncoxqzql", "nlifgomoftdvkpby", "pyikzbxoapffbqjw", "hzballplvzcsgjug", "ymjyigsfehmdsvgz", "vpqgyxknniunksko", "ffkmaqsjxgzclsnq", "jcuxthbedplxhslk", "ymlevgofmharicfs", "nyhbejkndhqcoisy", "rjntxasfjhnlizgm", "oqlnuxtzhyiwzeto", "tntthdowhewszitu", "rmxyoceuwhsvfcua", "qpgsjzwenzbxyfgw", "sumguxpdkocyagpu", "ymfrbxwrawejkduu", "hetgrtmojolbmsuf", "qzqizpiyfasgttex", "qnmoemcpuckzsshx", "ddyqiihagcmnxccu", "oirwxyfxxyktgheo", "phpaoozbdogbushy", "uctjdavsimsrnvjn", "aurbbphvjtzipnuh", "hpbtrubopljmltep", "pyyvkthqfsxqhrxg", "jdxaiqzkepxbfejk", "ukgnwbnysrzvqzlw", "lfkatkvcssnlpthd", "ucsyecgshklhqmsc", "rwdcbdchuahkvmga", "rxkgqakawgpwokum", "hbuyxeylddfgorgu", "tbllspqozaqzglkz", "rqfwizjlbwngdvvi", "xuxduyzscovachew", "kouiuxckkvmetvdy", "ycyejrpwxyrweppd", "trctlytzwiisjamx", "vtvpjceydunjdbez", "gmtlejdsrbfofgqy", "jgfbgtkzavcjlffj", "tyudxlpgraxzchdk", "gyecxacqitgozzgd", "rxaocylfabmmjcvt", "tornfzkzhjyofzqa", "kocjcrqcsvagmfqv", "zfrswnskuupivzxb", "cunkuvhbepztpdug", "pmpfnmklqhcmrtmf", "tfebzovjwxzumxap", "xpsxgaswavnzkzye", "lmwijdothmxclqbr", "upqxhmctbltxkarl", "axspehytmyicthmq", "xdwrhwtuooikehbk", "tpggalqsytvmwerj", "jodysbwnymloeqjf", "rxbazvwuvudqlydn", "ibizqysweiezhlqa", "uexgmotsqjfauhzp", "ldymyvumyhyamopg", "vbxvlvthgzgnkxnf", "pyvbrwlnatxigbrp", "azxynqididtrwokb", "lwafybyhpfvoawto", "ogqoivurfcgspytw", "cinrzzradwymqcgu", "sgruxdvrewgpmypu", "snfnsbywuczrshtd", "xfzbyqtyxuxdutpw", "fmpvjwbulmncykbo", "ljnwoslktrrnffwo", "ceaouqquvvienszn", "yjomrunrxjyljyge", "xpmjsapbnsdnbkdi", "uetoytptktkmewre", "eixsvzegkadkfbua", "afaefrwhcosurprw", "bwzmmvkuaxiymzwc", "gejyqhhzqgsrybni", "gjriqsfrhyguoiiw", "gtfyomppzsruhuac", "ogemfvmsdqqkfymr", "jgzbipsygirsnydh", "zghvlhpjnvqmocgr", "ngvssuwrbtoxtrka", "ietahyupkbuisekn", "gqxqwjizescbufvl", "eiprekzrygkncxzl", "igxfnxtwpyaamkxf", "soqjdkxcupevbren", "fspypobyzdwstxak", "qstcgawvqwtyyidf", "gsccjacboqvezxvd", "bfsblokjvrqzphmc", "srezeptvjmncqkec", "opmopgyabjjjoygt", "msvbufqexfrtecbf", "uiaqweyjiulplelu", "pbkwhjsibtwjvswi", "xwwzstmozqarurrq", "nytptwddwivtbgyq", "ejxvsufbzwhzpabr", "jouozvzuwlfqzdgh", "gfgugjihbklbenrk", "lwmnnhiuxqsfvthv", "bzvwbknfmaeahzhi", "cgyqswikclozyvnu", "udmkpvrljsjiagzi", "zzuhqokgmisguyna", "ekwcdnjzuctsdoua", "eueqkdrnzqcaecyd", "lnibwxmokbxhlris", "fdrbftgjljpzwhea", "iabvuhhjsxmqfwld", "qgogzkynrgejakta", "mfcqftytemgnpupp", "klvhlhuqhosvjuqk", "gdokmxcgoqvzvaup", "juududyojcazzgvr", "fyszciheodgmnotg", "yfpngnofceqfvtfs", "cahndkfehjumwavc", "dxsvscqukljxcqyi", "cqukcjtucxwrusji", "vevmmqlehvgebmid", "ahswsogfrumzdofy", "ftasbklvdquaxhxb", "tsdeumygukferuif", "ybfgbwxaaitpwryg", "djyaoycbymezglio", "trzrgxdjqnmlnzpn", "rumwchfihhihpqui", "ffrvnsgrnzemksif", "oizlksxineqknwzd", "cirqcprftpjzrxhk", "zrhemeqegmzrpufd", "kqgatudhxgzlgkey", "syjugymeajlzffhq", "nlildhmgnwlopohp", "flcszztfbesqhnyz", "ohzicmqsajyqptrw", "ebyszucgozsjbelq", "enxbgvvcuqeloxud", "ubwnvecbsmhkxwuk", "noifliyxvlkqphbo", "hazlqpetgugxxsiz", "ihdzoerqwqhgajzb", "ivrdwdquxzhdrzar", "synwycdvrupablib", "mqkdjkntblnmtvxj", "qmmvoylxymyovrnq", "pjtuxskkowutltlq", "gchrqtloggkrjciz", "namzqovvsdipazae", "yfokqhkmakyjzmys", "iapxlbuoiwqfnozm", "fbcmlcekgfdurqxe", "ednzgtczbplwxjlq", "gdvsltzpywffelsp", "oaitrrmpqdvduqej", "gseupzwowmuuibjo", "dfzsffsqpaqoixhh", "tclhzqpcvbshxmgx", "cfqkptjrulxiabgo", "iraiysmwcpmtklhf", "znwjlzodhktjqwlm", "lcietjndlbgxzjht", "gdkcluwjhtaaprfo", "vbksxrfznjzwvmmt", "vpfftxjfkeltcojl", "thrmzmeplpdespnh", "yafopikiqswafsit", "xxbqgeblfruklnhs", "qiufjijzbcpfdgig", "ikksmllfyvhyydmi", "sknufchjdvccccta", "wpdcrramajdoisxr", "grnqkjfxofpwjmji", "lkffhxonjskyccoh", "npnzshnoaqayhpmb", "fqpvaamqbrnatjia", "oljkoldhfggkfnfc", "ihpralzpqfrijynm", "gvaxadkuyzgbjpod", "onchdguuhrhhspen", "uefjmufwlioenaus", "thifdypigyihgnzo", "ugqblsonqaxycvkg", "yevmbiyrqdqrmlbw", "bvpvwrhoyneorcmm", "gbyjqzcsheaxnyib", "knhsmdjssycvuoqf", "nizjxiwdakpfttyh", "nwrkbhorhfqqoliz", "ynsqwvwuwzqpzzwp", "yitscrgexjfclwwh", "dhajwxqdbtrfltzz", "bmrfylxhthiaozpv", "frvatcvgknjhcndw", "xlvtdmpvkpcnmhya", "pxpemuzuqzjlmtoc", "dijdacfteteypkoq", "knrcdkrvywagglnf", "fviuajtspnvnptia", "xvlqzukmwbcjgwho", "bazlsjdsjoeuvgoz", "nslzmlhosrjarndj", "menvuwiuymknunwm", "uavfnvyrjeiwqmuu", "yrfowuvasupngckz", "taevqhlrcohlnwye", "skcudnogbncusorn", "omtnmkqnqedsajfv", "yqmgsqdgsuysqcts", "odsnbtyimikkbmdd", "vuryaohxdvjllieb", "dhaxldeywwsfamlo", "opobvtchezqnxpak", "pzfnegouvsrfgvro", "rzkcgpxdslzrdktu", "ksztdtqzxvhuryam", "ctnqnhkcooqipgkh", "pyqbbvrzdittqbgm", "koennvmolejeftij", "rvzlreqikqlgyczj", "xrnujfoyhonzkdgd", "mmsmhkxaiqupfjil", "ypjwoemqizddvyfd", "qgugcxnbhvgahykj", "cviodlsrtimbkgmy", "xbfbbechhmrjxhnw", "psuipaoucfczfxkp", "hdhwcpeuptgqqvim", "gsxlruhjeaareilr", "vgyqonnljuznyrhk", "eewezahlumervpyu", "iiolebrxfadtnigy", "tdadlrodykrdfscn", "ocvdtzjxrhtjurpo", "gidljbuvuovkhhrf", "qwfcpilbjwzboohd", "xzohxonlezuiupbg", "vslpbkkqgvgbcbix", "pivzqrzfxosbstzn", "fyqcfboevcqmbhhs", "yqsrneacnlxswojx", "heicqpxxyrwcbsjz", "yzynmnnoumkmlbeh", "bncadbjdvvmczylw", "hlnjskgfzbgmigfn", "fphpszymugpcykka", "zbifcktanxpmufvy", "saklpkhoyfeqbguy", "nqtqfcfxmpivnjyo", "locygrwerxlsvzqm", "qqflecydqvlogjme", "njklmixvgkzpgppf", "ugzkpjwjflaswyma", "lriousvkbeftslcy", "nsvsauxzfbbotgmh", "tblcpuhjyybrlica", "hqwshxcilwtmxrsf", "xojwroydfeoqupup", "tikuzsrogpnohpib", "layenyqgxdfggloc", "nqsvjvbrpuxkqvmq", "ivchgxkdlfjdzxmk", "uoghiuosiiwiwdws", "twsgsfzyszsfinlc", "waixcmadmhtqvcmd", "zkgitozgrqehtjkw", "xbkmyxkzqyktmpfi", "qlyapfmlybmatwxn", "ntawlvcpuaebuypf", "clhebxqdkcyndyof", "nrcxuceywiklpemc", "lmurgiminxpapzmq", "obalwqlkykzflxou", "huvcudpiryefbcye", "zlxbddpnyuyapach", "gqfwzfislmwzyegy", "jhynkjtxedmemlob", "hmrnvjodnsfiukex", "pstmikjykzyavfef", "wuwpnscrwzsyalyt", "hksvadripgdgwynm", "tvpfthzjleqfxwkh", "xpmrxxepkrosnrco", "qjkqecsnevlhqsly", "jjnrfsxzzwkhnwdm", "pehmzrzsjngccale", "bsnansnfxduritrr", "ejzxkefwmzmbxhlb", "pceatehnizeujfrs", "jtidrtgxopyeslzl", "sytaoidnamfwtqcr", "iabjnikomkgmyirr", "eitavndozoezojsi", "wtsbhaftgrbqfsmm", "vvusvrivsmhtfild", "qifbtzszfyzsjzyx", "ifhhjpaqatpbxzau", "etjqdimpyjxiuhty", "fvllmbdbsjozxrip", "tjtgkadqkdtdlkpi", "xnydmjleowezrecn", "vhcbhxqalroaryfn", "scgvfqsangfbhtay", "lbufpduxwvdkwhmb", "tshipehzspkhmdoi", "gtszsebsulyajcfl", "dlrzswhxajcivlgg", "kgjruggcikrfrkrw", "xxupctxtmryersbn", "hljjqfjrubzozxts", "giaxjhcwazrenjzs", "tyffxtpufpxylpye", "jfugdxxyfwkzqmgv", "kbgufbosjghahacw", "xpbhhssgegmthwxb", "npefofiharjypyzk", "velxsseyxuhrpycy", "sglslryxsiwwqzfw", "susohnlpelojhklv", "lfnpqfvptqhogdmk", "vtcrzetlekguqyle", "jlyggqdtamcjiuxn", "olxxqfgizjmvigvl", "cyypypveppxxxfuq", "hewmxtlzfqoqznwd", "jzgxxybfeqfyzsmp", "xzvvndrhuejnzesx", "esiripjpvtqqwjkv", "xnhrwhjtactofwrd", "knuzpuogbzplofqx", "tihycsdwqggxntqk", "xkfywvvugkdalehs", "cztwdivxagtqjjel", "dsaslcagopsbfioy", "gmowqtkgrlqjimbl", "ctcomvdbiatdvbsd", "gujyrnpsssxmqjhz", "nygeovliqjfauhjf", "mmgmcvnuppkbnonz", "bhipnkoxhzcotwel", "wkwpgedgxvpltqid", "mliajvpdocyzcbot", "kqjhsipuibyjuref", "zqdczykothbgxwsy", "koirtljkuqzxioaz", "audpjvhmqzvhzqas", "cxyhxlhntyidldfx", "iasgocejboxjgtkx", "abehujmqotwcufxp", "fmlrzqmazajxeedl", "knswpkekbacuxfby", "yvyalnvrxgstqhxm", "sjnrljfrfuyqfwuw", "ssaqruwarlvxrqzm", "iaxbpeqqzlcwfqjz", "uwyxshjutkanvvsc", "uxwrlwbblcianvnb", "nodtifgrxdojhneh", "mloxjfusriktxrms", "lkfzrwulbctupggc", "gcrjljatfhitcgfj", "tkdfxeanwskaivqs", "ypyjxqtmitwubbgt", "ssxbygzbjsltedjj", "zdrsnoorwqfalnha", "xlgmissaiqmowppd", "azhbwhiopwpguiuo", "fydlahgxtekbweet", "qtaveuqpifprdoiy", "kpubqyepxqleucem", "wlqrgqmnupwiuory", "rwyocktuqkuhdwxz", "abzjfsdevoygctqv", "zsofhaqqghncmzuw", "lqbjwjqxqbfgdckc", "bkhyxjkrqbbunido", "yepxfjnnhldidsjb", "builayfduxbppafc", "wedllowzeuswkuez", "gverfowxwtnvgrmo", "tpxycfumxdqgntwf", "lqzokaoglwnfcolw", "yqsksyheyspmcdqt", "vufvchcjjcltwddl", "saeatqmuvnoacddt", "dxjngeydvsjbobjs", "ucrcxoakevhsgcep", "cajgwjsfxkasbayt", "hknzmteafsfemwuv", "xxwhxwiinchqqudr", "usfenmavvuevevgr", "kxcobcwhsgyizjok", "vhqnydeboeunnvyk", "bgxbwbxypnxvaacw", "bwjzdypacwgervgk", "rrioqjluawwwnjcr", "fiaeyggmgijnasot", "xizotjsoqmkvhbzm", "uzphtrpxwfnaiidz", "kihppzgvgyoncptg", "hfbkfrxwejdeuwbz", "zgqthtuaqyrxicdy", "zitqdjnnwhznftze", "jnzlplsrwovxlqsn", "bmwrobuhwnwivpca", "uuwsvcdnoyovxuhn", "nmfvoqgoppoyosaj", "hxjkcppaisezygpe", "icvnysgixapvtoos", "vbvzajjgrmjygkhu", "jinptbqkyqredaos", "dpmknzhkhleawfvz", "ouwwkfhcedsgqqxe", "owroouiyptrijzgv", "bewnckpmnbrmhfyu", "evdqxevdacsbfbjb", "catppmrovqavxstn", "dqsbjibugjkhgazg", "mkcldhjochtnvvne", "sblkmhtifwtfnmsx", "lynnaujghehmpfpt", "vrseaozoheawffoq", "ytysdzbpbazorqes", "sezawbudymfvziff", "vrlfhledogbgxbau", "bipdlplesdezbldn", "ermaenjunjtbekeo", "eyaedubkthdecxjq", "gbzurepoojlwucuy", "rsiaqiiipjlouecx", "beqjhvroixhiemtw", "buzlowghhqbcbdwv", "ldexambveeosaimo", "fpyjzachgrhxcvnx", "komgvqejojpnykol", "fxebehjoxdujwmfu", "jnfgvheocgtvmvkx", "qmcclxxgnclkuspx", "rsbelzrfdblatmzu", "vexzwqjqrsenlrhm", "tnfbkclwetommqmh", "lzoskleonvmprdri", "nnahplxqscvtgfwi", "ubqdsflhnmiayzrp", "xtiyqxhfyqonqzrn", "omdtmjeqhmlfojfr", "cnimgkdbxkkcnmkb", "tapyijgmxzbmqnks", "byacsxavjboovukk", "awugnhcrygaoppjq", "yxcnwrvhojpuxehg", "btjdudofhxmgqbao", "nzqlfygiysfuilou", "nubwfjdxavunrliq", "vqxmmhsbmhlewceh", "ygavmcybepzfevrp", "kgflmrqsvxprkqgq", "iaqyqmcaedscmakk", "cvbojnbfmrawxzkh", "jjjrprbnlijzatuw", "lcsudrrfnnggbrmk", "qzgxbiavunawfibc", "gnnalgfvefdfdwwg", "nokmiitzrigxavsc", "etzoxwzxqkkhvais", "urxxfacgjccieufi", "lqrioqhuvgcotuec", "dydbaeyoypsbftra", "hhrotenctylggzaf", "evctqvzjnozpdxzu", "tbpvithmorujxlcp", "pllbtcbrtkfpvxcw", "fzyxdqilyvqreowv", "xdleeddxwvqjfmmt", "fcldzthqqpbswoin", "sgomzrpjfmvgwlzi", "axjyskmtdjbxpwoz", "hcvaevqxsmabvswh", "lfdlsfcwkwicizfk", "isjbwpzdognhoxvm", "oqnexibqxlyxpluh", "zqfbgodsfzwgcwuf", "kvmnwruwsjllbldz", "kghazimdyiyhmokj", "uiktgpsxpoahofxn", "zkdwawxargcmidct", "ftbixlyiprshrjup", "nofhmbxififwroeg", "mcdaqrhplffxrcdt", "fbjxnwojcvlawmlb", "rizoftvwfdhiwyac", "eduogrtyhxfwyars", "zoikunqxgjwfqqwr", "zxwbbpmvctzezaqh", "nghujwyeabwdqnop", "vcxamijpoyyksogn", "jnckdbuteoqlsdae", "jurfqqawafmsiqwv", "inepmztrzehfafie", "tznzkyvzodbrtscf", "xewbavjeppflwscl", "ucndzsorexjlnplo", "jpxbctscngxgusvu", "mfmygcllauzuoaok", "oibkuxhjmhxhhzby", "zjkslwagmeoisunw", "avnnxmopdgvmukuu", "jmaargejcwboqhkt", "yacmpeosarsrfkrv", "iqhgupookcaovwgh", "ebjkdnxwtikqzufc", "imdhbarytcscbsvb", "ifyibukeffkbqvcr", "aloighmyvwybtxhx", "yszqwrutbkiwkxjg", "xyholyzlltjhsuhp", "gykhmrwucneoxcrf", "badkdgqrpjzbabet", "sunaucaucykwtkjj", "pumqkglgfdhneero", "usgtyuestahlydxq", "xmfhflphzeudjsjm", "knywgmclisgpootg", "mtojnyrnvxtweuzb", "uuxufbwfegysabww", "vobhwwocqttlbsik", "yuydfezeqgqxqmnd", "wbqgqkwbibiilhzc", "sfdmgxsbuzsawush", "ilhbxcfgordyxwvp", "ahqoavuysblnqaeg", "plwgtvpgotskmsey", "ewjcmzkcnautrrmp", "tyekgzbznlikcyqj", "bqzctiuaxpriuiga", "bimvbfjkiupyqiys", "mpqtbcxfhwymxncw", "htemlptvqhharjgb", "mqbsmsruwzzxgcxc", "zjyedjwhnvteuaid", "pzoelkoidwglpttc", "efydnsvlfimvwxhx", "gfyhgoeiyjcgfyze", "deqtomhwopmzvjlt", "casafubtkoopuaju", "yylsfarntbucfulg", "mgjwsormkjsrrxan", "lkkenpupgmjpnqqd", "tegweszyohsoluot", "lihsfdwxmxvwdxna", "rrefrjjxerphejwb", "guuazonjoebhymtm", "ysofqzmfmyneziki", "lmjgaliatcpduoal", "qzthcpjwtgahbebr", "wvakvephyukmpemm", "simxacxxzfoaeddw", "aetgqmiqzxbvbviz", "jxlmhdmqggevrxes", "mmuglnjmuddzgaik", "svopsqhtrslgycgc", "xnvcsiiqrcjkvecn", "kkvumxtvashxcops", "bduflsdyeectvcgl", "vfrxbwmmytjvqnsj", "eeqtdneiyiaiofxw", "crtbgknfacjtwkfl", "uuutuoxdsxolpbhd", "lcrztwzreaswovtn", "htorkvnvujmjdqzj", "wttzuzvrzlyhfzyf", "oraewznfwgdsnhuk", "rctlkqqvkwbgrcgk", "cfehrsrqhzyiwtmz", "kbvxwcumjkhvjpui", "xxlocexbmniiakfo", "gtknkkzvykmlqghl", "kcjuxvkuimhwqrtk", "vohekwkuyuoacuww", "vorctgughscysyfo", "zmjevqplngzswxyq", "qhswdrhrijnatkyo", "joakcwpfggtitizs", "juzlwjijcmtswdtq", "icbyaqohpkemhkip", "rpdxgpzxncedmvzh", "rozkmimbqhbhcddv", "wkkypomlvyglpfpf", "jcaqyaqvsefwtaya", "ghvmtecoxlebdwnf", "lqrcyiykkkpkxvqt", "eqlarfazchmzotev", "vqwndafvmpguggef", "dbfxzrdkkrusmdke", "cmjpjjgndozcmefj", "hbrdcwjuyxapyhlo", "mmforetykbosdwce", "zynfntqwblbnfqik", "sodwujfwlasznaiz", "yyvrivjiqnxzqkfp", "uldbskmmjbqllpnm", "fyhhrmrsukeptynl", "hpfjekktvdkgdkzl", "bozhkoekcxzeorob", "uvpptyfrzkvmtoky", "hkhfprmjdpjvfkcb", "igxzwktwsqhsivqu", "qceomwysgkcylipb", "cglateoynluyeqgc", "xcsdfkpeguxgvpfh", "owjhxlcncdgkqyia", "rpbmrpcesiakqpna", "lueszxiourxsmezb", "zelvsowimzkxliwc", "vzxbttoobtvdtkca", "pfxvzphzwscqkzsi", "edsjorainowytbzu", "ipsegdaluoiphmnz", "mkhueokfpemywvuw", "urxdnumhylpafdlc", "ggluurzavsxkvwkl", "ctclphidqgteakox", "tfobosynxsktajuk", "jzrmemhxqmzhllif", "eemwekimdfvqslsx", "yjkwpzrbanoaajgq", "rlxghzanuyeimfhx", "hozbgdoorhthlqpv", "obkbmflhyanxilnx", "xojrippyxjmpzmsz", "ukykmbfheixuviue", "qivlmdexwucqkres", "rmyxxipqkarpjmox", "fgaftctbvcvnrror", "raawxozucfqvasru", "dinpjbdfjfizexdh", "gybxubwnnbuyvjcr", "qrqitdvyoneqyxcg", "jqzcfggayzyoqteo", "cikqpvxizpdbmppm", "stfpldgyhfmucjjv", "slzbcuihmimpduri", "aufajwfrsorqqsnl", "iylmzraibygmgmqj", "lcdyfpcqlktudfmu", "pmomzzsdpvgkkliw", "zpplirgtscfhbrkj", "mvhyerxfiljlotjl", "ofkvrorwwhusyxjx", "xngzmvcgkqfltjpe", "yxfxaqipmysahqqq", "sdqafdzgfdjuabup", "qcqajmerahcdgxfv", "xqimrqtupbapawro", "qfvkqwidzzrehsbl", "himixxvueksiqfdf", "vgtfqpuzxxmhrvvd", "adiioqeiejguaost", "jnzxuycjxvxehbvm", "xedbpxdhphamoodk", "jsrioscmwlsfuxrg", "mtsynnfxunuohbnf", "enamqzfzjunnnkpe", "uwcvfecunobyhces", "ciygixtgbsccpftq", "ewjgcronizkcsfjy", "wztjkoipxsikoimv", "jrgalyvfelwxforw", "imylyalawbqwkrwb", "yflwqfnuuvgjsgcj", "wkysyzusldlojoue", "zopllxnidcffcuau", "bscgwxuprxaerskj", "zvnvprxxjkhnkkpq", "nejwxbhjxxdbenid", "chryiccsebdbcnkc", "guoeefaeafhlgvxh", "nzapxrfrrqhsingx", "mkzvquzvqvwsejqs", "kozmlmbchydtxeeo", "keylygnoqhmfzrfp", "srwzoxccndoxylxe", "uqjzalppoorosxxo", "potmkinyuqxsfdfw", "qkkwrhpbhypxhiun", "wgfvnogarjmdbxyh", "gkidtvepcvxopzuf", "atwhvmmdvmewhzty", "pybxizvuiwwngqej", "zfumwnazxwwxtiry", "keboraqttctosemx", "vtlzxaqdetbhclib", "wjiecykptzexuayl", "ejatfnyjjdawepyk", "mpcrobansyssvmju", "gqukndzganeueabm", "ukzscvomorucdnqd", "wfydhtbzehgwfazx", "mtwqdzlephqvxqmx", "dltmlfxbjopefibh", "atcfrowdflluqtbi", "vowawlophlxaqonw", "vblgdjzvwnocdipw", "uzerzksmkvnlvlhm", "ytjwhpaylohorvxd", "siprvfxvnxcdgofz", "cbhjupewcyjhvtgs", "apqtozaofusmfqli", "tmssrtlxfouowqnr", "ntutrvwnzzgmokes", "zrsgpwdzokztdpis", "nrobvmsxtfmrqdhv", "kadkaftffaziqdze", "yrovbgcyqtlsnoux", "modheiwuhntdecqs", "gzhjypwddizemnys", "gaputpwpcsvzxjho", "bgmouxwoajgaozau", "oxuapfrjcpyakiwt", "kntwbvhuaahdixzj", "epqjdjbnkxdnaccx", "dspltdvznhypykri", "tdrgqmbnagrxdwtt", "njfqawzjggmemtbg", "chpemsgwpzjpdnkk", "fpsrobmbqbmigmwk", "flxptsrqaazmprnl", "nzdunrxlcbfklshm", "miuwljvtkgzdlbnn", "xbhjakklmbhsdmdt", "xwxhsbnrwnegwcov", "pwosflhodjaiexwq", "fhgepuluczttfvqh", "tldxcacbvxyamvkt", "gffxatrjglkcehim", "tzotkdrpxkucsdps", "wxheftdepysvmzbe", "qfooyczdzoewrmku", "rvlwikuqdbpjuvoo", "bcbrnbtfrdgijtzt", "vaxqmvuogsxonlgq", "ibsolflngegravgo", "txntccjmqakcoorp", "vrrbmqaxfbarmlmc", "dzspqmttgsuhczto", "pikcscjunxlwqtiw", "lwzyogwxqitqfqlv", "gsgjsuaqejtzglym", "feyeqguxbgmcmgpp", "gmttebyebdwvprkn", "mzuuwbhzdjfdryxu", "fganrbnplymqbzjx", "cvsrbdcvhtxxdmro", "scmgkjlkqukoamyp", "fkgrqbyqpqcworqc", "hjsrvkdibdjarxxb", "sztzziuqroeidcus", "pxdfvcpvwaddrzwv", "phdqqxleqdjfgfbg", "cqfikbgxvjmnfncy" };

        public static void Run()
        {
            PartOne();
            PartTwo();
            
        }

        static void PartOne()
        {

            //Contains at least 3 vowels
            var regVowels = new Regex(@"\b(?:[^aeiou\W]*[aeiuo]){3,}[^aeiou\W]*\b");
            //1 double letter
            var regDouble = new Regex(@"(.)\1{1}");
            // Does not contain ab,cd,pq,xy 
            var disqualifiers = new List<string>(){ "ab","cd","pq","xy" };

            int answer = input.Count(x => regVowels.IsMatch(x) && regDouble.IsMatch(x));
           
            Console.WriteLine($"Day 5 Part One Answer : {answer}");

        }

        static void PartTwo()
        {

            int answer = 0;
            var inputTest = new List<string>(){ "ieodomkazucvgmuy" };
            foreach (var word in input)
            {
                var letters = word.ToCharArray();
                var hsSameLetters = new HashSet<Matches>();
                bool hasPair = false;
                bool hasRepeat = false;

                char first = letters[0];
                char second;

                //Check Pair
                for(var i = 1; i < letters.Count(); i++)
                {
                    second = letters[i];
                    
                    var matches = hsSameLetters.Where(x => x.FirstLetter == first && x.SecondLetter == second);

                    if(matches.Count() == 0)
                    {
                        hsSameLetters.Add(new Matches() { FirstLetter = first, SecondLetter = second, Position = i });
                    }
                    else
                    {
                        var same = matches.Where(x => x.Position == i || x.Position == i - 1);

                        if(same.Count() == 0)
                        {
                            hasPair = true;
                        }
                    }
                        
                    
                    first = second;
                }

                //Check Repeat
                char? one = null;
                char? two = null;
                char? three = null;

                for (var i = 1; i < letters.Count(); i++)
                {
                    if(one == null)
                    {
                        one = letters[i];
                    }else if(two == null)
                    {
                        two = letters[i];
                    }else if(three == null)
                    {
                        three = letters[i];
                    }else
                    {
                        one = two;
                        two = three;
                        three = letters[i];

                    }

                    if (one == three)
                    {
                        hasRepeat = true;
                    }

                }

                if (hasPair && hasRepeat)
                {
                    answer++;
                }

            }
            
            Console.WriteLine($"Day 5 Part 2 Answer : {answer}");
        }

        class Matches
        {
            public char FirstLetter { get; set; }
            public char SecondLetter { get; set; }
            public int Position { get; set; }
        }

        static bool DQ(List<string> d, string record)
        {
            return d.Count(a => record.Contains(a)) == 0;
        }

        

    }

}
