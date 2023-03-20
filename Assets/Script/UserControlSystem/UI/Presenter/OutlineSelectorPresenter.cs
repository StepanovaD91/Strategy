using UnityEngine;

public class OutlineSelectorPresenter : MonoBehaviour
{
    [SerializeField] private SelectableValue _selectableValue;

    private OutlineSelector[] _outlineSelectors;
    private ISelecatable _currentSelectable;

    private void Start()
    {
        _selectableValue.OnNewValue += ONSelected;
    }

    private void ONSelected(ISelecatable selecatable)
    {
        if(_currentSelectable == selecatable)
        {
            return;
        }

        SetSelected(_outlineSelectors, false);
        _outlineSelectors = null;

        if (selecatable != null)
        {
            _outlineSelectors = (selecatable as Component).GetComponentsInParent<OutlineSelector>();
            SetSelected(_outlineSelectors, true);
        }
        else
        {
            if (_outlineSelectors != null)
            {
                SetSelected(_outlineSelectors, false);
            }
        }

        _currentSelectable = selecatable;

        static void SetSelected(OutlineSelector[] selectors, bool value)
        {
            if (selectors != null)
            {
                for (int i = 0; i < selectors.Length; i++)
                {
                   selectors[i].SetSelected(value); 
                }
            }
        }
    }
}

