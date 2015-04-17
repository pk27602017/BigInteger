﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigIntegerTests
{
    [TestClass]
    public class Operators
    {
        [TestMethod]
        public void TestAdd()
        {
            BigInteger a, b, c;
            var rand = new Random();

            // Basic tests
            for (long i = -512; i <= 512; i++)
            {
                for (long j = -512; j <= 512; j++)
                {
                    a = new BigInteger(i);
                    b = new BigInteger(j);

                    c = a + b;
                    var res = i + j;

                    Assert.AreEqual(c.LongValue(), res);
                }
            }

            // Random tests
            for (long i = -512; i <= 512; i++)
            {
                for (long j = -512; j <= 512; j++)
                {
                    var r1 = (long)rand.Next() * (rand.Next(1) == 1 ? 1 : -1);
                    var r2 = (long)rand.Next() * (rand.Next(1) == 1 ? 1 : -1);

                    a = new BigInteger(r1);
                    b = new BigInteger(r2);

                    c = a + b;
                    var res = r1 + r2;

                    Assert.AreEqual(c.LongValue(), res);
                }
            }

            // Real big integer tests
            a = new BigInteger("8736450165021643590276576435071654972987560219654872658726450196581645190562874576982560293545415641561134565643613134856464131543614315432145613113251361564360325135156436113243251324135132541321321325156135132032513213132013213213212245554745313548545641354568", 10);
            b = new BigInteger("9589804375234529843520257250197527438756190572985720751876587432654315605015016587165016598265983650156014501987657826598726598258529058873259835484564348564318375431864856734543518756434343543514875643613435443843618754856486468", 10);
            c = new BigInteger("8736450165021643590276576435071664562791935454184716178983700394109083946753447562703312170132848295876739580660200299873062397527264471446647600771077960290958583664215309373078735888483696859696753190012869675551269647475556728088855858990189157167300497841036", 10);

            Assert.IsTrue(a + b == c);


            a = new BigInteger("12345678900987654327509827439521875687165871654871624871632874168754432187527561875687265873165614871267458726498516687463218746186587156982436519856287651876541987461873264719659872659821658971659871635897168759216345872695876235987169875694385621439582458761785619874536", 10);
            b = new BigInteger("-197250947592354676587168326544327592769243757616587165924376587327645981759165716985621851685761985618569845014591451876587213469758546321258997686534312545679863928524618545676882466432595794352957928516458716501657759825190654879145871649517654179568756987351905769074502375025676658576576543287587679874198180987547656655453213254365768798980", 10);
            c = new BigInteger("-197250947592354676587168326544327592769243757616587165924376587327645981746820038084634197358252158179047969327425580221715588598125672152504565499006750669992598055359003674409423739934079106889739182329871559519221239968903003002603884187644389459908884327530246797414630739128507899360230670591711443887028305293162035215870754492580148924444", 10);

            Assert.IsTrue(a + b == c);


            a = new BigInteger("-846182698321765872364598716598716876541987654287643871632498721643876198741687324629837546982736587265165879265026435872654982654872658169875462543698726548168546286589276581628756298437562865981687465287436598217645198648752643875619865982164582659615438762875462987658726581768562985629865298765982658265928685496186186458264865189618756913562983562987435619564356175465426458297456198618651545546498572685246582", 10);
            b = new BigInteger("90982572562752843592693546036540069287547626625732528585695693960029029582385273456265256257758689546993569603406070078040596256196526586295869568563956010681656869364594505065065056056235695175698756569560456056560157650171650563169065541547667916597041049509712847103247537817645758457198741857410957174817690174019402701547608773651574107484760478097471798510710191505769074093", 10);
            c = new BigInteger("-846182698321765872364598716598716785559415091534800278938952685103806911194060698897308961287042627236136296879752979607398724896183111176305859137628648507572290090062690285759187734481552184324818100692931533152589142413057468176863296421708526099457788591224899818593185034100646388588815789053135555018390867850427729259523007778661582095872809543584734071955582523891318973536978101146853034836307066916172489", 10);

            Assert.IsTrue(a + b == c);


            a = new BigInteger("-143116129142147100108206211999412925323512122319935244411571711620818353211823922738123824219237145184156190248255402110431233172111232193186196216157233143144338448187176235934118012919717017716313510564128382321542192011051752000238214676020919371182141192197811425215812718014614712815721712020218519924815721210412731691621203206156981982274891313115124320419679516414612236221238231571051822536584173661321255114871174235192149168154115191102188626214189941646914319123423522515614523621911921812167168240881108", 10);
            b = new BigInteger("-7618313625226185189689191161119172622551392401211363818022414118641199142250253582199723815220836132359877166433316981219432082261911349420832241749017482245197151824415989199161101601051302222276513724467137234311391021172231045314214758151128458511573918432511299433111052531951680126245210541891673948231821821560150176214146236200102385511254693519825425119915", 10);
            c = new BigInteger("-143116129142147100108206211999412925323512122319935244411571711620818353211823922738123824219237145184156190248255402110431233172111232193186196216157240761457963674372365925125279132092339569108714721927946404735660833210194002253820414399836140207314501069364244742197032150096876624165142544261967537407060918362237147680820364307758033284497167826839591457653990907435784467266552446329202950995095747579753766414304285287724100848280360401644080300162421763468474469299637668751814626007423176505686993666001023", 10);

            Assert.IsTrue(a + b == c);

            // EXTREMELY BIG integers test
            // ...
        }

        [TestMethod]
        public void TestMultiply()
        {
            BigInteger a, b, c;
            var rand = new Random();

            // Basic tests
            for (long i = -512; i <= 512; i++)
            {
                for (long j = -512; j <= 512; j++)
                {
                    a = new BigInteger(i);
                    b = new BigInteger(j);

                    c = a * b;
                    var res = i * j;

                    Assert.AreEqual(c.LongValue(), res);
                }
            }
                        
            // Random tests
            for (long i = -512; i <= 512; i++)
            {
                for (long j = -512; j <= 512; j++)
                {
                    var r1 = (long)rand.Next() * (rand.Next(1) == 1 ? 1 : -1);
                    var r2 = (long)rand.Next() * (rand.Next(1) == 1 ? 1 : -1);

                    a = new BigInteger(r1);
                    b = new BigInteger(r2);

                    c = a * b;
                    var res = r1 * r2;

                    Assert.AreEqual(c.LongValue(), res);
                }
            }

            // Real big integers test
            a = new BigInteger("7811710925219674103129126132513723865201203352041081817105302522209313648228312167240615217752324357418681911881141591708510848820621761713068235812224117711817021020010216057177148170249211233113153128179671647023817011914920114", 10);
            b = new BigInteger("9223054121107166203262288519186227178212439289228182341091100141492502114224823226191250981688212200165755960122269815581308811711310016622821571192024888826316261172171031553191311212006391611717721924422827311050121412321951261125", 10);
            c = new BigInteger("72047832641745189467980397277026012803116912716201944939987021240155835089786188672907047351415328367344068907056036920638390797495252691454568396757459367625308561549933019341977496257312871429875208373293570464556829756951480430140341735893572407238378943293991278799225871482694330656016486325399881151555458875115889131759135597833969442795242028147472927010646289485128044982192718439705402509500463910104562048170884718303337196953813878118649905928768250", 10);

            Assert.IsTrue(a * b == c);
            Assert.IsTrue(b * a == c);


            a = new BigInteger("4513022378190195207248111493619814210011122111521314021116172245292421892189133135249253284210917322371331631915863149241442281401995510735118116112172202199102116124234501111031274954151507124570516154178228146", 10);
            b = new BigInteger("-21214549242251052241771111591231922718116196124215208237223791301188221671711551412061274721321259968357174338744185133212247992212194487821696331561772417319610919166291912065196162119240406645225236219191201", 10);
            c = new BigInteger("-95741735473496847450965298491222332762394146649819187685557014747349940684668656525190467421314098643330324386874220739620089289104694591142434525621230200031619218858159061195623414162314523246055739860772747134175243061665895940704847415587359211445714766035301321126416641175320071188574625625836279308951452708369892772413091211318328698249704338677729982421168528063257663731682901727639305794962588919451373743346", 10);

            Assert.IsTrue(a * b == c);
            Assert.IsTrue(b * a == c);


            a = new BigInteger("-1902461566877254356412382193972281261151421501631222226102249128136473189301133123430209246103432885424610919710218647747316746149103129591395511820932150141691705515820262718618860115109249517622562103230", 10);
            b = new BigInteger("2529589762471071921217177179249254145111191246515169611931940652006643560213582062372288573701152271112332092452431128143210751781625037196701031611573185126122233723864211061301331715378213129937", 10);
            c = new BigInteger("-4812447303067377156001370465508698710143790469896017909084443930917546661166426085194221384468237928018138443323364337419326783795368084635417486675814494422114548346072946174750410766023327134636410859442705546846351433154572227134592317317276406630779877922713644485272768885284691618693139016912821086816430687870159399140437067347680654378681734078871270760285197463560553049439591521779997396510", 10);

            Assert.IsTrue(a * b == c);
            Assert.IsTrue(b * a == c);


            a = new BigInteger("-247591179113641726551092614110625414798935918518724122820820437114157176122150116155147163249531902042815123926201107174145159106177331812411071181451961901867411679619889911423332302151161271871731281996751", 10);
            b = new BigInteger("-1901451752166201123615117460180134106115469530198221101148139213244232139159294257161130100221131998623613429152205724784253201353613576243221173117715423921616891162039248250113239924828222546010224826168", 10);
            c = new BigInteger("470782681346529800216759025446747092045188631141622615445464429840250748896490263346676188477401449398784352124574498378830506322639352584202116605974693692194824763263949618703029846313252400361025245824301828641617858127932941468016666971398736792667282916657805322080902778987073711188483372360907612588995664533157503380846449774089269965646418521613225981431666593065726252482995754339317299670566915780168", 10);

            Assert.IsTrue(a * b == c);
            Assert.IsTrue(b * a == c);

            // EXTREMELY BIG integers test
            // ...
        }

        [TestMethod]
        public void TestSubtract()
        {
            BigInteger a, b, c, d;
            var rand = new Random();

            // Basic tests
            for (long i = -512; i <= 512; i++)
            {
                for (long j = -512; j <= 512; j++)
                {
                    a = new BigInteger(i);
                    b = new BigInteger(j);

                    c = a - b;
                    var res = i - j;

                    Assert.AreEqual(c.LongValue(), res);
                }
            }

            // Random tests
            for (long i = -512; i <= 512; i++)
            {
                for (long j = -512; j <= 512; j++)
                {
                    var r1 = (long)rand.Next() * (rand.Next(1) == 1 ? 1 : -1);
                    var r2 = (long)rand.Next() * (rand.Next(1) == 1 ? 1 : -1);

                    a = new BigInteger(r1);
                    b = new BigInteger(r2);

                    c = a - b;
                    var res = r1 - r2;

                    Assert.AreEqual(c.LongValue(), res);
                }
            }

            // Real big integer tests
            a = new BigInteger("2370875548284040084915495892885398213065887697057039912071418570985765468925273993872357952411727634674006325626751123989243154600600121108596826886351096943456110157261249324313500191611392523067838484368996921188678981288422374785377963193271438685", 10);
            b = new BigInteger("9842809278821697926856753926285521510370565246595469186904586495936311421194032073672665652687489527148908404976869815839770736828785607846337077162641408151427563295134300138364950461264480838064985064235851923500874353455279787308905018582555634168", 10);
            c = new BigInteger("-7471933730537657841941258033400123297304677549538429274833167924950545952268758079800307700275761892474902079350118691850527582228185486737740250276290311207971453137873050814051450269653088314997146579866855002312195372166857412523527055389284195483", 10);
            d = new BigInteger("7471933730537657841941258033400123297304677549538429274833167924950545952268758079800307700275761892474902079350118691850527582228185486737740250276290311207971453137873050814051450269653088314997146579866855002312195372166857412523527055389284195483", 10);

            Assert.IsTrue(a - b == c);
            Assert.IsTrue(b - a == d);


            a = new BigInteger("584207928318313703759959581421229250630225514822332446539461008127740140011264652140663182462291690372586800686737283622", 10);
            b = new BigInteger("6142456532845908741357465763333631126698478081542673696010404128653603081983487472906887743804004679072318691248686832101049581348239815542642963628179333994148633178497402384721729083552745123052689517808609339113798027772764718238918816155349582608778873197028120873210855085948", 10);
            c = new BigInteger("-6142456532845908741357465763333631126698478081542673696010404128653603081983487472906887743804004679072318691248686832101049581348239815542642963628179333994148048970569084071017969123971323893802059292293787006667258566764636978098907551503208919426316581506655534072524117802326", 10);
            d = new BigInteger("6142456532845908741357465763333631126698478081542673696010404128653603081983487472906887743804004679072318691248686832101049581348239815542642963628179333994148048970569084071017969123971323893802059292293787006667258566764636978098907551503208919426316581506655534072524117802326", 10);

            Assert.IsTrue(a - b == c);
            Assert.IsTrue(b - a == d);


            a = new BigInteger("72393004014008616948699376080189214737182901463915103626148948615863971640896921596193186868059658445648944439700797779331717007875461714210644076972331813726291867293948933574671707370278623041755084", 10);
            b = new BigInteger("7623531488224692231", 10);
            c = new BigInteger("72393004014008616948699376080189214737182901463915103626148948615863971640896921596193186868059658445648944439700797779331717007875461714210644076972331813726291867293948933574671699746747134817062853", 10);
            d = new BigInteger("-72393004014008616948699376080189214737182901463915103626148948615863971640896921596193186868059658445648944439700797779331717007875461714210644076972331813726291867293948933574671699746747134817062853", 10);

            Assert.IsTrue(a - b == c);
            Assert.IsTrue(b - a == d);


            a = new BigInteger("25294770628028014060", 10);
            b = new BigInteger("72574805741936720295456361551828697911515565771186387397920613494208951645107222049471595344247731961649232693237174108029605579742118055374406542154880093374299224667176015179749092064372386289529289843531723752262817234145189916397824867451361670889203466218", 10);
            c = new BigInteger("-72574805741936720295456361551828697911515565771186387397920613494208951645107222049471595344247731961649232693237174108029605579742118055374406542154880093374299224667176015179749092064372386289529289843531723752262817234145189916397824867426066900261175452158", 10);
            d = new BigInteger("72574805741936720295456361551828697911515565771186387397920613494208951645107222049471595344247731961649232693237174108029605579742118055374406542154880093374299224667176015179749092064372386289529289843531723752262817234145189916397824867426066900261175452158", 10);

            Assert.IsTrue(a - b == c);
            Assert.IsTrue(b - a == d);


            a = new BigInteger("242274348546746746561809174519140413997624638548431519590221194238021680115895439627191763027756139278491647769985995227130244754388458404745244759751071819577181391198155822831727930709415353289821347675311840373942682845289962379758960054", 10);
            b = new BigInteger("70257936843325427757829505852047086051482996258544359224975621760714819112963882019347633282227000662037636432234585990703085724821581080328122270298285387358103621219289793198131679567085651604672725400140878828998613904225614092542671555581268832431617812956", 10);
            c = new BigInteger("-70257936843325427757587231503500339304921187084025218810977997122166387593373660825109611602111105222410444669206829851424594077051595085100992025543896928953358376459538721378554498175887495781840997469431463475708792556550302252168728872735978870051858852902", 10);
            d = new BigInteger("70257936843325427757587231503500339304921187084025218810977997122166387593373660825109611602111105222410444669206829851424594077051595085100992025543896928953358376459538721378554498175887495781840997469431463475708792556550302252168728872735978870051858852902", 10);

            Assert.IsTrue(a - b == c);
            Assert.IsTrue(b - a == d);


            a = new BigInteger("336", 10);
            b = new BigInteger("2477815157435451159259865086015519689777610111110989156364590597216620377013741459367006696310696128224783540745423222222849611894998463819032020545479131866791056148486548144247554040261339340376156637250385760963353913114248364231701700067462160413", 10);
            c = new BigInteger("-2477815157435451159259865086015519689777610111110989156364590597216620377013741459367006696310696128224783540745423222222849611894998463819032020545479131866791056148486548144247554040261339340376156637250385760963353913114248364231701700067462160077", 10);
            d = new BigInteger("2477815157435451159259865086015519689777610111110989156364590597216620377013741459367006696310696128224783540745423222222849611894998463819032020545479131866791056148486548144247554040261339340376156637250385760963353913114248364231701700067462160077", 10);

            Assert.IsTrue(a - b == c);
            Assert.IsTrue(b - a == d);
        }

        [TestMethod]
        public void TestDivide()
        {
            BigInteger a, b, c, d;
            var rand = new Random();

            // Basic tests
            for (long i = -512; i <= 512; i++)
            {
                for (long j = -512; j <= 512; j++)
                {
                    if (j != 0)
                    {
                        a = new BigInteger(i);
                        b = new BigInteger(j);

                        c = a / b;
                        var res = i / j;

                        Assert.AreEqual(c.LongValue(), res);
                    }
                }
            }

            // Random tests
            for (long i = -512; i <= 512; i++)
            {
                for (long j = -512; j <= 512; j++)
                {
                    var r1 = (long)rand.Next() * (rand.Next(1) == 1 ? 1 : -1);
                    var r2 = (long)rand.Next() * (rand.Next(1) == 1 ? 1 : -1);

                    if (r2 != 0)
                    {
                        a = new BigInteger(r1);
                        b = new BigInteger(r2);

                        c = a / b;
                        var res = r1 / r2;

                        Assert.AreEqual(c.LongValue(), res);
                    }
                }
            }

            // Real big integers test
            a = new BigInteger("1520103907346259794304485905491384144513868297140907866549441656176806962010861186795174778956936119665451726851398277493821938174298117680119637254730378387115386665481434876496459306840143869207485599774887590709125332121244546147365050750765792662", 10);
            b = new BigInteger("3999170270695661167125183897430052640952506821419546747664948326507294916391520075713045588951029445106077991789053811538494517968922681074315058017231373659734714443845125774429854839908871090202431255705514496816005420683556878836231229356354689841", 10);
            c = new BigInteger("0", 10);
            d = new BigInteger("2", 10);

            Assert.IsTrue(a / b == c);
            Assert.IsTrue(b / a == d);


            a = new BigInteger("557347027213049151872333651175919392578273530012875632597120502546133653767183867204661879816468351720102550434006037767442283672620540147203006498870431068794294609113918879458325122005522270885631913032999837968002395404248811354377863373", 10);
            b = new BigInteger("97321785096586384404576536892622463265470592101631141178782042453213213722526256282594524620328322379772208364261412475138132047013676000334642505844668209561922485146669750056289262093538067149050337999370868539855484212791671474275739104759968809793842204794", 10);
            c = new BigInteger("0", 10);
            d = new BigInteger("174616137423811115840", 10);

            Assert.IsTrue(a / b == c);
            Assert.IsTrue(b / a == d);


            a = new BigInteger("75766926743750142641", 10);
            b = new BigInteger("79390569616528709821959297813556037579482457009005427925469873884716771518526365083713466574612178655605675067900362357965007604668304432829892390128829736822796078593506902265946899946845292742915416978362201489509636356293269068849856231495920985543113736218", 10);
            c = new BigInteger("0", 10);
            d = new BigInteger("1047826182590644327541981421974409125034895284158816951737642600572659824334597294472349662166701029796215079869596471988812425673422488884248858133844635080410622278717155261366816119892895838859240233452877936978009781958643607328286816310", 10);

            Assert.IsTrue(a / b == c);
            Assert.IsTrue(b / a == d);


            a = new BigInteger("8", 10);
            b = new BigInteger("293078830000343517737627824179874674152869176285244020772101676128244242799045288043266903309965031700474566495279453141122143492800442470919872387288489707709448942608252062244963099120475341651358361283211504016198245595297775281961016485", 10);
            c = new BigInteger("0", 10);
            d = new BigInteger("36634853750042939717203478022484334269108647035655502596512709516030530349880661005408362913745628962559320811909931642640267936600055308864984048411061213463681117826031507780620387390059417706419795160401438002024780699412221910245127060", 10);

            Assert.IsTrue(a / b == c);
            Assert.IsTrue(b / a == d);


            a = new BigInteger("7922979246910827809352526221915910891922035086331687466952117388591759888744012900738661776995811935451952547128525307772267407113856986260068830544968971284269028677617383069795635690350980516465499439371982695988945081830068608824845629534", 10);
            b = new BigInteger("581644631823123355097082396904224378241593392185037682795813930339112794067178242264631646728947627864627097563696492944331110375198460759770636800866434143766129693252355145128449552620367725147061701681247297729772569634200053145907098230", 10);
            c = new BigInteger("13", 10);
            d = new BigInteger("0", 10);

            Assert.IsTrue(a / b == c);
            Assert.IsTrue(b / a == d);

            // EXTREMELY BIG integers test
            // ...
        }

        [TestMethod]
        public void TestRemainder()
        {
        }

        [TestMethod]
        public void TestIncrement()
        {
        }

        [TestMethod]
        public void TestDecrement()
        {
        }

        [TestMethod]
        public void TestShiftRight()
        {
        }

        [TestMethod]
        public void TestShiftleft()
        {
        }

        [TestMethod]
        public void TestBitwiseNOT()
        {
        }

        [TestMethod]
        public void TestBitwiseAND()
        {
        }

        [TestMethod]
        public void TestBitwiseOR()
        {
        }

        [TestMethod]
        public void TestBitwiseXOR()
        {
        }

        [TestMethod]
        public void TestNegate()
        {
        }

        [TestMethod]
        public void TestEqual()
        {
            BigInteger a, b, c, d;
            var rand = new Random();

            // Basic tests
            for (int i = -512; i <= 512; i++)
            {
                for (int j = -512; j <= 512; j++)
                {
                    a = new BigInteger(i);
                    b = new BigInteger(j);
                    c = a;
                    d = b;

                    if (i == j)
                        Assert.IsTrue(a == b);
                    else
                        Assert.IsFalse(a == b);

                    Assert.IsTrue(a == c);
                    Assert.IsTrue(b == d);
                }
            }
                        
            // Random tests
            for (long i = -512; i <= 512; i++)
            {
                for (long j = -512; j <= 512; j++)
                {
                    var r1 = (long)rand.Next() * (rand.Next(1) == 1 ? 1 : -1);
                    var r2 = (long)rand.Next() * (rand.Next(1) == 1 ? 1 : -1);

                    a = new BigInteger(r1);
                    b = new BigInteger(r2);
                    c = a;
                    d = b;

                    if (r1==r2)
                        Assert.IsTrue(a == b);
                    else
                        Assert.IsFalse(a == b);

                    Assert.IsTrue(a == c);
                    Assert.IsTrue(b == d);
                }
            }

            a = new BigInteger("1472422046014128199621021221192537119020025976718474951581131171015215234227220625356191217347210713443722381542227039188124735921596412515651557320342254110218172133122162204191162143255255058118120017014721961472441051496822747163214178230954169109", 10);
            b = new BigInteger("1472422046014128199621021221192537119020025976718474951581131171015215234227220625356191217347210713443722381542227039188124735921596412515651557320342254110218172133122162204191162143255255058118120017014721961472441051496822747163214178230954169109", 10);

            Assert.IsTrue(a == b);
            Assert.IsTrue(b == a);


            a = new BigInteger("12220714188451191671562112331511911147020423315820212320120631129122452057211355211761130231585316992121147801112713021240261821321221491921289661122521855021468451891962228521431179328011525421621929252200195158103230878032186102181160113214177250151821293240141", 10);
            b = new BigInteger("12220714188451191671562112331511911147020423315820212320120631129122452057211355211761130231585316992121147801112713021240261821321221491921289661122521855021468451891962228521431179328011525421621929252200195158103230878032186102181160113214177250151821293240141", 10);

            Assert.IsTrue(a == b);
            Assert.IsTrue(b == a);


            a = new BigInteger("12220714188451191671562112331511911147020423315820212320120631129122452057211355211761130231585316992121147801112713021240261821321221491921289661122521855021468451891962228521431179328011525421621929252200195158103230878032186102181160113214177250151821293240141", 10);
            b = new BigInteger("1472422046014128199621021221192537119020025976718474951581131171015215234227220625356191217347210713443722381542227039188124735921596412515651557320342254110218172133122162204191162143255255058118120017014721961472441051496822747163214178230954169109", 10);

            Assert.IsFalse(a == b);
            Assert.IsFalse(b == a);


            a = new BigInteger("8441438076139892242322222352121442031052061501302161807217820012848832259531139513518289512820780213741729218631213175117199178199200122114112154688523914249122138721322125419015218115185248204107119237752122291242392511661302512072051004330151751071503210182176140", 10);
            b = new BigInteger("1566418015110056215187231389616519534577516579792275171111641261221051312281313815513819230315922221620199110721958389124169108971797193714911636204254753718521720234123778235733313467254631402533915314654249108131105183249173121122367515221314612118015725347", 10);

            Assert.IsFalse(a == b);
            Assert.IsFalse(b == a); ;
        }

        [TestMethod]
        public void TestNotEqual()
        {
            BigInteger a, b, c, d;
            var rand = new Random();

            for (int i = -512; i <= 512; i++)
            {
                for (int j = -512; j <= 512; j++)
                {
                    a = new BigInteger(i);
                    b = new BigInteger(j);
                    c = a;
                    d = b;

                    if (i != j)
                        Assert.IsTrue(a != b);
                    else
                        Assert.IsFalse(a != b);

                    Assert.IsFalse(a != c);
                    Assert.IsFalse(b != d);
                }
            }

            // Random tests
            for (long i = -512; i <= 512; i++)
            {
                for (long j = -512; j <= 512; j++)
                {
                    var r1 = (long)rand.Next() * (rand.Next(1) == 1 ? 1 : -1);
                    var r2 = (long)rand.Next() * (rand.Next(1) == 1 ? 1 : -1);

                    a = new BigInteger(r1);
                    b = new BigInteger(r2);
                    c = a;
                    d = b;

                    if (r1 != r2)
                        Assert.IsTrue(a != b);
                    else
                        Assert.IsFalse(a != b);

                    Assert.IsFalse(a != c);
                    Assert.IsFalse(b != d);
                }
            }


            a = new BigInteger("1472422046014128199621021221192537119020025976718474951581131171015215234227220625356191217347210713443722381542227039188124735921596412515651557320342254110218172133122162204191162143255255058118120017014721961472441051496822747163214178230954169109", 10);
            b = new BigInteger("1472422046014128199621021221192537119020025976718474951581131171015215234227220625356191217347210713443722381542227039188124735921596412515651557320342254110218172133122162204191162143255255058118120017014721961472441051496822747163214178230954169109", 10);

            Assert.IsFalse(a != b);
            Assert.IsFalse(b != a);


            a = new BigInteger("12220714188451191671562112331511911147020423315820212320120631129122452057211355211761130231585316992121147801112713021240261821321221491921289661122521855021468451891962228521431179328011525421621929252200195158103230878032186102181160113214177250151821293240141", 10);
            b = new BigInteger("12220714188451191671562112331511911147020423315820212320120631129122452057211355211761130231585316992121147801112713021240261821321221491921289661122521855021468451891962228521431179328011525421621929252200195158103230878032186102181160113214177250151821293240141", 10);

            Assert.IsFalse(a != b);
            Assert.IsFalse(b != a);


            a = new BigInteger("12220714188451191671562112331511911147020423315820212320120631129122452057211355211761130231585316992121147801112713021240261821321221491921289661122521855021468451891962228521431179328011525421621929252200195158103230878032186102181160113214177250151821293240141", 10);
            b = new BigInteger("1472422046014128199621021221192537119020025976718474951581131171015215234227220625356191217347210713443722381542227039188124735921596412515651557320342254110218172133122162204191162143255255058118120017014721961472441051496822747163214178230954169109", 10);

            Assert.IsTrue(a != b);
            Assert.IsTrue(b != a);


            a = new BigInteger("2115621117118216155351891761662361601584411102174510620722219313128151133231861922331201297951341011841661916821134454513123022219180184211100931397209922191068743951571221141101477015724620517760102124782421202131691446114938210135180318716378254319223423677220141", 10);
            b = new BigInteger("6642919818616176131244121254232104172291771056024558244136134113162189752042520821416322391206189187442372102122451032245913441801706515621341181133233237224121146184120148193281341326721898919116325424490143141167492481431241423819154173204239115719821914410145", 10);

            Assert.IsTrue(a != b);
            Assert.IsTrue(b != a);
        }

        [TestMethod]
        public void TestGreater()
        {
        }

        [TestMethod]
        public void TestGreaterOrEqual()
        {
        }

        [TestMethod]
        public void TestLess()
        {
        }

        [TestMethod]
        public void TestLessOrEqual()
        {
        }
    }
}
