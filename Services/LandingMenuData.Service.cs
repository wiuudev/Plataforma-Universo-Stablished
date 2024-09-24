public class LandingMenuDataService
{
    private List<MainMenuItems> MenuData = new List<MainMenuItems>()
    {
        new MainMenuItems (
            path: "landing/#home",
            type: "link",
            title: "Início",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "landing/#about",
            type: "link",
            title: "Sobre",
            selected: false,
            active: false,
            dirChange: false
        ),
        
        new MainMenuItems (
            type: "sub",
            title: "Mais",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "landing/#statistics",
                    type: "link",
                    title: "Estatísticas",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "landing/#our-mission",
                    type: "link",
                    title: "Nossa missão",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "landing/#features",
                    type: "link",
                    title: "Benefícios",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "landing/#testimonials",
                    type: "link",
                    title: "Depoimentos",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        
        new MainMenuItems (
            path: "landing/#testimonials",
            type: "link",
            title: "Clientes",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "landing/#team",
            type: "link",
            title: "Equipe",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "landing/#pricing",
            type: "link",
            title: "Preço",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "landing/#faq",
            type: "link",
            title: "Perguntas frequentes",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "landing/#contact",
            type: "link",
            title: "Contato",
            selected: false,
            active: false,
            dirChange: false
        ),
    };

    public List<MainMenuItems> GetMenuData()
   {
        return MenuData;
    }
}
