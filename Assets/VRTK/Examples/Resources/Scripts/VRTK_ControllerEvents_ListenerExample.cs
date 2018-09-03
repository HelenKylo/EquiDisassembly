namespace VRTK.Examples
{
    using UnityEngine;

    public class VRTK_ControllerEvents_ListenerExample : MonoBehaviour
    {
        private void Start()
        {
            if (GetComponent<VRTK_ControllerEvents>() == null)
            {
                Debug.LogError("VRTK_ControllerEvents_ListenerExample is required to be attached to a Controller that has the VRTK_ControllerEvents script attached to it");
                return;
            }

            #region 事件

            //Setup controller event listeners
            GetComponent<VRTK_ControllerEvents>().TriggerPressed += new ControllerInteractionEventHandler(DoTriggerPressed);
            GetComponent<VRTK_ControllerEvents>().TriggerReleased += new ControllerInteractionEventHandler(DoTriggerReleased);

            GetComponent<VRTK_ControllerEvents>().TriggerTouchStart += new ControllerInteractionEventHandler(DoTriggerTouchStart);
            GetComponent<VRTK_ControllerEvents>().TriggerTouchEnd += new ControllerInteractionEventHandler(DoTriggerTouchEnd);

            GetComponent<VRTK_ControllerEvents>().TriggerHairlineStart += new ControllerInteractionEventHandler(DoTriggerHairlineStart);
            GetComponent<VRTK_ControllerEvents>().TriggerHairlineEnd += new ControllerInteractionEventHandler(DoTriggerHairlineEnd);

            GetComponent<VRTK_ControllerEvents>().TriggerClicked += new ControllerInteractionEventHandler(DoTriggerClicked);
            GetComponent<VRTK_ControllerEvents>().TriggerUnclicked += new ControllerInteractionEventHandler(DoTriggerUnclicked);

            GetComponent<VRTK_ControllerEvents>().TriggerAxisChanged += new ControllerInteractionEventHandler(DoTriggerAxisChanged);

            GetComponent<VRTK_ControllerEvents>().ApplicationMenuPressed += new ControllerInteractionEventHandler(DoApplicationMenuPressed);
            GetComponent<VRTK_ControllerEvents>().ApplicationMenuReleased += new ControllerInteractionEventHandler(DoApplicationMenuReleased);

            GetComponent<VRTK_ControllerEvents>().GripPressed += new ControllerInteractionEventHandler(DoGripPressed);
            GetComponent<VRTK_ControllerEvents>().GripReleased += new ControllerInteractionEventHandler(DoGripReleased);

            GetComponent<VRTK_ControllerEvents>().TouchpadPressed += new ControllerInteractionEventHandler(DoTouchpadPressed);
            GetComponent<VRTK_ControllerEvents>().TouchpadReleased += new ControllerInteractionEventHandler(DoTouchpadReleased);

            GetComponent<VRTK_ControllerEvents>().TouchpadTouchStart += new ControllerInteractionEventHandler(DoTouchpadTouchStart);
            GetComponent<VRTK_ControllerEvents>().TouchpadTouchEnd += new ControllerInteractionEventHandler(DoTouchpadTouchEnd);

            GetComponent<VRTK_ControllerEvents>().TouchpadAxisChanged += new ControllerInteractionEventHandler(DoTouchpadAxisChanged);

            GetComponent<VRTK_ControllerEvents>().ControllerEnabled += new ControllerInteractionEventHandler(DoControllerEnabled);
            GetComponent<VRTK_ControllerEvents>().ControllerDisabled += new ControllerInteractionEventHandler(DoControllerDisabled);

            #endregion
        }

        private void DoTriggerPressed(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoTriggerReleased(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoTriggerClicked(object sender, ControllerInteractionEventArgs e)
        {
            
        }

        private void DoTriggerUnclicked(object sender, ControllerInteractionEventArgs e)
        {
            
        }

        #region 底层

        private void DebugLogger(uint index, string button, string action, ControllerInteractionEventArgs e)
        {

        }

        private void DoTriggerTouchStart(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoTriggerTouchEnd(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoTriggerHairlineStart(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoTriggerHairlineEnd(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoTriggerAxisChanged(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoApplicationMenuPressed(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoApplicationMenuReleased(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoGripPressed(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoGripReleased(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoTouchpadPressed(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoTouchpadReleased(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoTouchpadTouchStart(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoTouchpadTouchEnd(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoTouchpadAxisChanged(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoControllerEnabled(object sender, ControllerInteractionEventArgs e)
        {

        }

        private void DoControllerDisabled(object sender, ControllerInteractionEventArgs e)
        {

        }

        #endregion
    }
}