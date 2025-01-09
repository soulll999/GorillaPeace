using BepInEx;
namespace GorillaPeace
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public void Update()
        {
            foreach (GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
            {
                if (!line.muteButton.isOn)
                {
                    line.PressButton(true, GorillaPlayerLineButton.ButtonType.Mute);
                    
                    line.muteButton.UpdateColor();
                }
            }
        }
    }
}