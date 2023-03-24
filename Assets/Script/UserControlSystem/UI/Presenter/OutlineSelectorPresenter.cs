using System;
using UnityEngine;
using Zenject;
using UniRx;

public class OutlineSelectorPresenter : MonoBehaviour
{
    [Inject] private IObservable<ISelecatable> _selectedValues;

    private OutlineSelector[] _outlineSelectors;
    private ISelecatable _currentSelectable;

    private void Start()
    {
        _selectedValues.Subscribe(ONSelected);
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

