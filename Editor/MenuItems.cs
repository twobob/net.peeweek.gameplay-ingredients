using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameplayIngredients.Editor
{
    public static class MenuItems
    {
        const int kMenuPriority = 330;

        [MenuItem("Edit/Select None &D", priority = 149)]
        static void UnselectAll()
        {
            Selection.activeObject = null;
        }

        [MenuItem("Edit/Play from SceneView Position #%&P", priority = 160)]
        static void PlayHere()
        {
            EditorApplication.isPlaying = true;
        }

        [MenuItem("Edit/Play from SceneView Position #%&P", priority = 160)]
        static bool PlayHereValidate()
        {
            return true;
        }

        static readonly string helperPreferenceName = "GameplayIngredients.toggleIngredientHelpers";
        [MenuItem("Edit/Gameplay Ingredients/Toggle Helpers", priority = kMenuPriority)]
        static void ToggleIngredientHelpers()
        {
            bool value = EditorPrefs.GetBool(helperPreferenceName, false);
            value = !value;
            EditorPrefs.SetBool(helperPreferenceName, value);

        }

        [MenuItem("Edit/Gameplay Ingredients/Toggle Helpers", validate = true, priority = kMenuPriority)]
        static bool ToggleIngredientHelpersValidation()
        {
            Menu.SetChecked("Edit/Gameplay Ingredients/Toggle Helpers", EditorPrefs.GetBool(helperPreferenceName, false));
            return true;
        }

    }
}
