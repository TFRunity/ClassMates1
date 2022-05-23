using ClassMates.Models;
using ClassMates.InterFaces;
namespace ClassMates
{   //Каркас готов, осталось лишь вставить данные...
    public class DataBase : IAllPerson
    {
        //Student motorkin = Model.ElementAt(26);
        //Student sashashav = Model.ElementAt(27);
        //Student dimak = Model.ElementAt(28);
        //Student phezik = Model.ElementAt(29);
        //Student alexey = Model.ElementAt(30);
        public IEnumerable<object> ReturnObj
        {
            get
            {
                return new List<Student>
        {
            new Student
            {
                id = 0,
                Name = "Коля",
                Description = "Конченный идиот, об его подвигах слагают легенды." +
                " Невысокий рост для такого ума, около 180 см." +
                " Ходит слух, что у него есть мексиканские корни, из-за поедания которых у него в голове что-то щёлкнуло." +
                " Когда бог создавал Землю 6 дней он делал мир вокруг, на 7 сделал человека, а на следующей неделе Колю." +
                " Иногда Коля делает что-то не так, например думает о последствиях(никогда)." +
                " Когда-то давно Коля пометил толкан и позвал одноклассников взглянуть на сие творение." +
                " Когда вы находитесь рядом с ним, стоит опасаться за свой задний проход, ибо вставить для него плёвое дело." +
                " Единственный человек, ударивший по мячу вверх в зале и попавший по головам физруков дважды." +
                " Единственный человек, серьезно задавший себе вопрос: <А как какать?> " +
                " Шкала мемность сего индивида выше всех показателей: Сверхтупость и аутизм в чистом виде, оптимизм и слабоумие. ",
                DateBirth = "19.12.2005",
                FutureJob = "Грузчик",
                Img = new List<string>
                {
                "/images/koolya/1.jpg", "/images/koolya/2.jpg", "/images/koolya/3.jpg",
                "/images/koolya/4.jpg", "/images/koolya/5.jpg", "/images/koolya/6.jpg",
                "/images/koolya/7.jpg", "/images/koolya/8.jpg", "/images/koolya/9.jpg",
                "/images/koolya/10.jpg", "/images/koolya/11.jpg", "/images/koolya/12.jpg",
                "/images/koolya/13.jpg", "/images/koolya/14.jpg", "/images/koolya/15.jpg",
                "/images/koolya/16.jpg", "/images/koolya/17.jpg", "/images/koolya/18.jpg",
                "/images/koolya/19.jpg", "/images/koolya/20.jpg", "/images/koolya/21.jpg",
                "/images/koolya/22.jpg", "/images/koolya/23.jpg"

                },
                MainImg = "/images/koolya/4.jpg",
                ImgLink = "/images/koolya"
            },
            new Student
            {
                id = 1,
                Name = "Лиза",
                Description = "...",
                DateBirth = "20.05.2006",
                FutureJob = "Инженер-Физик",
                Img = new List<string>
                {
                "/images/liza/1.jpg","/images/liza/2.jpg","/images/liza/3.jpg",
                "/images/liza/4.jpg","/images/liza/5.jpg",
                },
                MainImg = "/images/liza/2.jpg",
                ImgLink = "/images/liza"
            },
            new Student
            {
                id = 2,
                Name = "Никита",
                Description = "...",
                DateBirth = "19.12.2005",
                FutureJob = "Акционер акций Газпрома",
                Img = new List<string>
                {
                "/images/nikitka/1.jpg","/images/nikitka/2.jpg","/images/nikitka/3.jpg",
                "/images/nikitka/4.jpg","/images/nikitka/5.jpg","/images/nikitka/6.jpg",
                "/images/nikitka/7.jpg","/images/nikitka/8.jpg","/images/nikitka/9.jpg"
                },
                MainImg = "/images/nikitka/9.jpg",
                ImgLink = "/images/nikitka"
            },
            new Student
            {
                id = 3,
                Name = "Ника",
                Description = "...",
                DateBirth = "18.08.2006",
                FutureJob = "МВДЭшница",
                Img = new List<string>
                {
                "/images/nika/1.jpg","/images/nika/2.jpg","/images/nika/3.jpg"
                },
                MainImg = "/images/nika/2.jpg",
                ImgLink = "/images/nika/"
            },
            new Student
            {
                id = 4,
                Name = "Егорик",
                Description = "...",
                DateBirth = "10.04.2006",
                FutureJob = "Программист-Фронтовик",
                Img = new List<string>
                {
                "/images/egor/1.jpg","/images/egor/2.jpg","/images/egor/3.jpg",
                "/images/egor/4.jpg","/images/egor/5.jpg","/images/egor/6.jpg",
                "/images/egor/7.jpg","/images/egor/8.jpg"
                },
                MainImg = "/images/egor/4.jpg",
                ImgLink = "/images/egor/"
            },
            new Student
            {
                id = 5,
                Name = "Данилка Иванов",
                Description = "...",
                DateBirth = "10.06.2006",
                FutureJob = "Программист-Фронтовик",
                Img = new List<string>
                {
                "/images/danila/1.jpg","/images/danila/2.jpg","/images/danila/3.jpg",
                "/images/danila/4.jpg","/images/danila/5.jpg","/images/danila/6.jpg",
                "/images/danila/7.jpg","/images/danila/8.jpg","/images/danila/9.jpg",
                "/images/danila/10.jpg","/images/danila/11.jpg","/images/danila/12.jpg",
                "/images/danila/13.jpg","/images/danila/14.jpg","/images/danila/15.jpg",
                "/images/danila/16.jpg","/images/danila/17.jpg","/images/danila/18.jpg",
                "/images/danila/19.jpg","/images/danila/20.jpg","/images/danila/21.jpg"
                },
                MainImg = "/images/danila/21.jpg",
                ImgLink = "/images/danila/"
            },
            new Student
            {
                id = 6,
                Name = "Димасик",
                Description = "...",
                DateBirth = "13.06.2006",
                FutureJob = "Автосборщик",
                Img = new List<string>
                {
                "/images/dimasik/1.jpg","/images/dimasik/2.jpg","/images/dimasik/3.jpg",
                "/images/dimasik/4.jpg","/images/dimasik/5.jpg","/images/dimasik/6.jpg",
                "/images/dimasik/7.jpg","/images/dimasik/8.jpg","/images/dimasik/9.jpg",
                "/images/dimasik/10.jpg","/images/dimasik/11.jpg","/images/dimasik/12.jpg",
                "/images/dimasik/13.jpg","/images/dimasik/14.jpg"
                },
                MainImg = "/images/dimasik/5.jpg",
                ImgLink = "/images/dimasik/"
            },
            new Student
            {
                id = 7,
                Name = "Кирилл Дубинин",
                Description = "...",
                DateBirth = "04.05.2006",
                FutureJob = "",
                Img = new List<string>
                {
                "/images/kirill/1.jpg","/images/kirill/2.jpg","/images/kirill/3.jpg",
                "/images/kirill/4.jpg","/images/kirill/5.jpg"
                },
                MainImg = "/images/kirill/2.jpg",
                ImgLink = "/images/kirill/"
            },
            new Student
            {
                id = 8,
                Name = "Сударь",
                Description = "",
                DateBirth = "21.07.2006",
                FutureJob = "...",
                Img = new List<string>
                {
                "/images/skirill/1.jpg","/images/skirill/2.jpg","/images/skirill/3.jpg",
                "/images/skirill/4.jpg"
                },
                MainImg = "/images/skirill/1.jpg",
                ImgLink = "/images/kirill/"
            },
            new Student
            {
                id = 9,
                Name = "Женёк",
                Description = "Самый топовый чувак на всём 3 ряду." +
                " Часто помогает всем, даже несмотря на то, что я не вернул ему около 3 ручек." +
                " В основном его можно встретить с Колей/Мишей, угарающим на их тупостью." +
                " Очень добрый, ни разу не видел, чтобы он хоть с кем-то конфликтовал." +
                " Средний, но запоминающийся рост и телосложение." +
                " Есть ощущение, что в основном на уроках думает Женя, а Миша кайфует и апает кубки обоим." +
                " Первый действующий бравл старсер класса.",
                DateBirth = "17.06.2006",
                FutureJob = "Радиорубка",
                Img = new List<string>
                {
                "/images/evgeniy/1.jpg","/images/evgeniy/2.jpg","/images/evgeniy/3.jpg"
                },
                MainImg = "/images/evgeniy/2.jpg",
                ImgLink = "/images/evgeniy/"
            },
            new Student
            {
                id = 10,
                Name = "Мишган",
                Description = "Этот импостер является самым часто ошибающимся на уроках существом." +
                " Иногда скажет, не подумав, а потом ржет над собой." +
                " Рост полторашка с кепкой, но скоро вырастет.(по крайней мере он так говорит)" +
                " Мечтает стать тренером-танцором, но не знает, что там нужна очень прямая спина." +
                " Второй действующий бравл старсер по кубкам в классе." +
                " Если вам нужно поговорить с кем-то, поговорите с ним. (нефиг сидеть ему, кайфовать)",
                DateBirth = "09.01.2007",
                FutureJob = "Танцор, тренер",
                Img = new List<string>
                {
                "/images/misha/1.jpg","/images/misha/2.jpg","/images/misha/3.jpg",
                "/images/misha/4.jpg","/images/misha/5.jpg"
                },
                MainImg = "/images/misha/2.jpg",
                ImgLink = "/images/misha/"
            },
            new Student
            {
                id = 11,
                Name = "Степанов Паша",
                Description = "Покемон, каких повидать надо." +
                " Разбил губу об что-то прямо перед ОГЭ по матеше." +
                " Я знаю, что он читает это с швом и не может смеяться(страдай)." +
                " Почему-то не любит каменьщиков, хотя это крупнейшая группировка класса." +
                " До 6 лет даже не знал, что есть русский язык." +
                " Может найти контакт с любым женским полом (от истеричек, до тихонь)." +
                " Можно узнать его по смеху, как у чайки.(резкий и непереходящий в что-то большее)" +
                " Часто рассудителен, но если знает, что ему это не по силам, не станет их тратить." +
                " Его любимое животное - капибара.(у них есть что-то общее)",
                DateBirth = "04.01.2006",
                FutureJob = "Он не ебёт",
                Img = new List<string>
                {
                 "/images/pavel/1.jpg","/images/pavel/2.jpg","/images/pavel/3.jpg",
                 "/images/pavel/4.jpg","/images/pavel/5.jpg","/images/pavel/6.jpg",
                 "/images/pavel/7.jpg","/images/pavel/8.jpg","/images/pavel/9.jpg",
                 "/images/pavel/10.jpg","/images/pavel/11.jpg","/images/pavel/12.jpg",
                 "/images/pavel/13.jpg","/images/pavel/14.jpg","/images/pavel/15.jpg"
                },
                MainImg = "/images/pavel/13.jpg",
                ImgLink = "/images/pavel/"
            },
            new Student
            {
                id = 12,
                Name = "Сашанов Павел",
                Description = "Статный мужчина, шарящий за маришровку." +
                " Часто помогает друзьям, в большинстве случаев видит ответственность." +
                " Умеет играть в волейбол!!!!!." +
                " Один из немногих, кто следит за своей физической формой." +
                " Ни разу не видел, чтобы он попадал в просак (исключение - биология)." +
                " (Характеристика Бабанова)" +
                " встречается только на пару с Моторкиным." +
                " Умён, но слишком хитёр." +
                " Что бы его разозлить и обидеть, достаточно сказать, что он не умеет играть." +
                " На улице встречается только с родителями." +
                " (Характеристика Рая).",
                DateBirth = "11.07.2006",
                FutureJob = "Неизвестно",
                Img = new List<string>
                {
                "/images/pavels/1.jpg","/images/pavels/2.jpg"
                },
                MainImg = "/images/pavels/1.jpg",
                ImgLink = "/images/pavels/"
            },
            new Student
            {
                id = 13,
                Name = "Рай",
                Description = "Тот самый одноклассник, который решил что может говорить что хочет и ему ничего не будет." +
                " Когда-то давно, сказав <Да пошло он нахер>, решил не делать биологию." +
                " Добрый, но если тронуть Шавыркин вмажет так, что мало не покажется." +
                " Имеет чувство юмора, но при этом никогда не следит за языком при <взрослых>, из-за чего часто имеет проблемы." +
                " Вообще кабан, шарит за моду и тренды." +
                " Положительный персонаж, может дать характеристику о почти каждом человеке." +
                " Часто идёт на уступки, если видит в этом здравый смысл.(и никак иначе)" +
                " Самый честный и прямолинейный из всего класса.",
                DateBirth = "24.12.2005",
                FutureJob = "Учитель истории",
                Img = new List<string>
                {
                "/images/ray/1.jpg","/images/ray/2.jpg","/images/ray/3.jpg",
                "/images/ray/4.jpg","/images/ray/5.jpg","/images/ray/6.jpg",
                "/images/ray/7.jpg","/images/ray/8.jpg","/images/ray/9.jpg"
                },
                MainImg = "/images/ray/1.jpg",
                ImgLink = "/images/ray/"
            },
            new Student
            {
                id = 14,
                Name = "Князев",
                Description = "Длинный черт, около 2 м." +
                " Можно перепутать его с столбом." +
                " Когда проходишь мимо оглядывайся, не начнет ли он делать <Снегопад>." +
                " Перхоти не меньше, чем знаний о СССР." +
                " Иногда едет кукухой и начинает говорить о том, насколько Сталин был великим человеком." +
                " Верит в коммунизм, хотя сам своим имуществом делиться отказывается." +
                " Его басистым голосом можно довести маленьких девочек до оргазма." +
                " Любит аниме и читать исторические книжки.",
                DateBirth = "18.10.2006",
                FutureJob = "КГБшник",
                Img = new List<string>
                {
                "/images/knyazev/1.jpg","/images/knyazev/2.jpg","/images/knyazev/3.jpg",
                "/images/knyazev/4.jpg",
                },
                MainImg = "/images/knyazev/1.jpg",
                ImgLink = "/images/knyazev/"
            },
            new Student
            {
                id = 15,
                Name = "Отец Сергий (Константинов)",
                Description = "Умный чертила, даже очень." +
                " Это тот самый ботаник из рекламы турников, который накачался и сам тебе пизды даст и учебник в жопу засунет." +
                " Остаётся человеком аккуратным, по крайней мере, не плюётся в мусорку, как Бабанов)." +
                " Поведение в 9 классе довольно социальное, в отличие от других классов." +
                " Добрый и большой, его накачанной спиной можно прикрыть даже пивное пузо Иванова." +
                " Посоветуется прежде чем что-либо сделать." +
                " Этот человек пойдет очень далеко, прежде всего из-за своего шага, длиной в пол-километра." +
                " (Сиё творение на половину накалякал Сергей Рай, бейте его, если не правда).",
                DateBirth = "03.04.2006",
                FutureJob = "...",
                Img = new List<string>
                {
                "/images/konst/1.jpg","/images/konst/2.jpg","/images/konst/3.jpg",
                "/images/konst/4.jpg","/images/konst/5.jpg","/images/konst/6.jpg"
                },
                MainImg = "/images/konst/2.jpg",
                ImgLink = "/images/konst/"
            },
            new Student
            {
                id = 16,
                Name = "Вадимка",
                Description = "...",
                DateBirth = "01.06.2006",
                FutureJob = "Убийца",
                Img = new List<string>
                {
                "/images/vadick/1.jpg","/images/vadick/2.jpg","/images/vadick/3.jpg",
                "/images/vadick/4.jpg","/images/vadick/5.jpg","/images/vadick/6.jpg",
                "/images/vadick/7.jpg","/images/vadick/8.jpg"
                },
                MainImg = "/images/vadick/5.jpg",
                ImgLink = "/images/vadick/"
            },
            new Student
            {
                id = 17,
                Name = "Вадим Романов",
                Description = "...",
                DateBirth = "19.06.2006",
                FutureJob = "Гробовщик",
                Img = new List<string>
                {
                "/images/vadim/1.jpg","/images/vadim/2.jpg","/images/vadim/3.jpg",
                "/images/vadim/4.jpg","/images/vadim/5.jpg","/images/vadim/6.jpg",
                "/images/vadim/7.jpg","/images/vadim/8.jpg","/images/vadim/9.jpg",
                "/images/vadim/10.jpg","/images/vadim/11.jpg","/images/vadim/12.jpg",
                "/images/vadim/13.jpg"
                },
                MainImg = "/images/vadim/9.jpg",
                ImgLink = "/images/vadim/"
            },
            new Student
            {
                id = 18,
                Name = "Роман",
                Description = "...",
                DateBirth = "20.09.2005",
                FutureJob = "...",
                Img = new List<string>
                {
                "/images/roman/1.jpg","/images/roman/2.jpg","/images/roman/3.jpg",
                "/images/roman/4.jpg","/images/roman/5.jpg","/images/roman/6.jpg",
                "/images/roman/7.jpg","/images/roman/8.jpg","/images/roman/9.jpg",
                "/images/roman/10.jpg","/images/roman/11.jpg","/images/roman/12.jpg",
                "/images/roman/13.jpg"
                },
                MainImg = "/images/roman/6.jpg",
                ImgLink = "/images/roman/"
            },
            new Student
            {
                id = 19,
                Name = "Аня",
                Description = "...",
                DateBirth = "22.08.2006",
                FutureJob = "Банковское дело",
                Img = new List<string>
                {
                "/images/kvaskova/1.jpg","/images/kvaskova/1.jpg"
                },
                MainImg = "/images/kvaskova/1.jpg",
                ImgLink = "/images/kvaskova/"
            },
            new Student
            {
                id = 20,
                Name = "Настя",
                Description = "...",
                DateBirth = "09.09.2006",
                FutureJob = "Cтюардесса",
                Img = new List<string>
                {
                "/images/nastya/1.jpg","/images/nastya/2.jpg","/images/nastya/3.jpg"
                },
                MainImg = "/images/nastya/3.jpg",
                ImgLink = "/images/nastya/"
            },
            new Student
            {
                id = 21,
                Name = "Вика",
                Description = "",
                DateBirth = "19.05.2006",
                FutureJob = "Кибер-безопасность",
                Img = new List<string>
                {
                "/images/zotina/1.jpg","/images/zotina/2.jpg","/images/zotina/3.jpg"
                },
                MainImg = "/images/zotina/3.jpg",
                ImgLink = "/images/zotina/"
            },
            new Student
            {
                id = 22,
                Name = "Арина",
                Description = "...",
                DateBirth = "...",
                FutureJob = "...",
                Img = new List<string>
                {
                "/images/lapteva/1.jpg","/images/lapteva/2.jpg","/images/lapteva/3.jpg",
                "/images/lapteva/4.jpg",
                },
                MainImg = "/images/lapteva/1.jpg",
                ImgLink = "/images/lapteva/"
            },
                                                                                                                                                                                                                                                                                    new Student
            {
                id = 23,
                Name = "Ариана",
                Description = "...",
                DateBirth = "24.05.2006",
                FutureJob = "Бухгалтер",
                Img = new List<string>
                {
                "/images/ariana/1.jpg","/images/ariana/2.jpg","/images/ariana/3.jpg",
                "/images/ariana/4.jpg","/images/ariana/5.jpg"
                },
                MainImg = "/images/ariana/4.jpg",
                ImgLink = "/images/ariana/"
            },
                                                                                                                                                                                                                                                                                                new Student
            {
                id = 24,
                Name = "Лёнечка",
                Description = "...",
                DateBirth = "13.05.2006",
                FutureJob = "Учёный-Ядерщик",
                Img = new List<string>
                {
                "/images/leonid/1.jpg","/images/leonid/2.jpg","/images/leonid/3.jpg",
                "/images/leonid/4.jpg","/images/leonid/5.jpg","/images/leonid/6.jpg",
                "/images/leonid/7.jpg","/images/leonid/8.jpg","/images/leonid/9.jpg",
                "/images/leonid/10.jpg"
                },
                MainImg = "/images/leonid/5.jpg",
                ImgLink = "/images/leonid/"
            },
                                                                                                                                                                                                                                                                                                            new Student
            {
                id = 25,
                Name = "Илюша",
                Description = "...",
                DateBirth = "07.08.2006",
                FutureJob = "Дизайнер",
                Img = new List<string>
                {
                "/images/ilyha/1.jpg","/images/ilyha/2.jpg","/images/ilyha/3.jpg",
                "/images/ilyha/4.jpg"
                },
                MainImg = "/images/ilyha/3.jpg",
                ImgLink = "/images/ilyha/"
            },
            new Student
            {
                id = 26,
                Name = "Моторкин",
                Description = "...",
                DateBirth = "...",
                FutureJob = "...",
                Img = new List<string>
                {
                "/images/motorkin/1.jpg","/images/motorkin/2.jpg","/images/motorkin/3.jpg"
                },
                MainImg = "/images/motorkin/1.jpg",
                ImgLink = "/images/motorkin/"
            },
            new Student
            {
                id = 27,
                Name = "Шавыркин",
                Description = "Про его волосы не одно поколение пчёл слагали былины." +
                " У него в волосах можно проводить лекции по ботанике." +
                " Перхоти настолько много, что муравьи могут построить мегаполис ." +
                " Приятный человек, довольно добрый." +
                " Тот, кто обосрёт Саню, будет иметь дело со мной." +
                " Мне можно, другим нет." +
                " Из кличок можно выбрать главное блюдо Питера-шаурма, шаверма, шавуха." +
                " Сий текст написал Сергей Рай.(бейте его, не меня) ",
                DateBirth = "...",
                FutureJob = "Бухгалтер",
                Img = new List<string>
                {
                "/images/shava/1.jpg","/images/shava/2.jpg","/images/shava/3.jpg"
                },
                MainImg = "/images/shava/3.jpg",
                ImgLink = "/images/shava/"
            },
            new Student
            {
                id = 28,
                Name = "Кузьмин",
                Description = "...",
                DateBirth = "05.11.2005",
                FutureJob = "Педофил",
                Img = new List<string>
                {
                "/images/dimak/1.jpg","/images/dimak/2.jpg"
                },
                MainImg = "/images/dimak/1.jpg",
                ImgLink = "/images/dimak/"
            },
            new Student
            {
                id = 29,
                Name = "Фезик",
                Description =
                "Чёрт приезжий." +
                " ",
                DateBirth = "Когда-то давным-давно",
                FutureJob = "Грузчик/слесарь/каменьщик",
                Img = new List<string>
                {
                "/images/phezik/1.jpg","/images/phezik/2.jpg","/images/phezik/3.jpg",
                "/images/phezik/7.jpg","/images/phezik/5.jpg","/images/phezik/6.jpg"
                },
                MainImg = "/images/phezik/5.jpg",
                ImgLink = "/images/phezik/"
            },
            new Student
            {
                id = 30,
                Name = "Алексей",
                Description =
                "Этот чёрт из разряда тех гнид, которые я бы захотел обходить стороной." +
                " Ростом около 175 см, злой снаружи, добрый внутри." +
                " С ним очень сложно разговаривать ввиду его различных психических состояний." +
                " Иногда бывает зол, но держит в себе, чтобы не ёбнуть по Коле ботинком." +
                " Самый разносторонний, не курит, не пьет, ходит в зал и самосовершенствуется." +
                " Имеет право так говорить, т.к. является создателем этого сайта." +
                " Часто является источником ужасных или бредовых идей, напрявленных на повышение уровня смеха." +
                " Контактирует со всеми людьми в классе, плюется в мусорную корзину.",
                DateBirth = "30.05.2006",
                FutureJob = "Фулл-стек Разработчик",
                Img = new List<string>
                {
                "/images/babenov/1.jpg","/images/babenov/2.jpg","/images/babenov/3.jpg",
                "/images/babenov/4.jpg","/images/babenov/5.jpg","/images/babenov/6.jpg",
                "/images/babenov/7.jpg","/images/babenov/8.jpg","/images/babenov/9.jpg",
                },
                MainImg = "/images/babenov/1.jpg",
                ImgLink = "/images/babenov/"
            },
            new Student
            {
                id = 31,
                Name = "Общие фотокарточки:",
                Description = "Общие фотки, налетай",
                Img = new List<string>
                {
                "/images/Obchie/1.jpg","/images/Obchie/2.jpg","/images/Obchie/3.jpg",
                "/images/Obchie/4.jpg","/images/Obchie/5.jpg","/images/Obchie/6.jpg",
                "/images/Obchie/7.jpg","/images/Obchie/8.jpg","/images/Obchie/9.jpg",
                "/images/Obchie/10.jpg","/images/Obchie/11.jpg","/images/Obchie/12.jpg",
                "/images/Obchie/13.jpg","/images/Obchie/14.jpg","/images/Obchie/15.jpg",
                "/images/Obchie/16.jpg","/images/Obchie/17.jpg","/images/Obchie/18.jpg",
                "/images/Obchie/19.jpg","/images/Obchie/20.jpg","/images/Obchie/21.jpg",
                "/images/Obchie/22.jpg","/images/Obchie/23.jpg","/images/Obchie/24.jpg",
                "/images/Obchie/25.jpg"
                },
                MainImg = "/images/Obchie/5.jpg",
                ImgLink = "/images/Obchie/"
            },
        };
    }
}
    }
}
