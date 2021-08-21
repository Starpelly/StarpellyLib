# Pelly
Tools for Unity

Random window title every 0.1 seconds:
```cs
using UnityEngine;

using Pelly.Enums;
using Pelly.Random;
using Pelly.OS;

public class RandomWindowTitle : MonoBehaviour
{
    private float action = 0.0f;
    private float period = 0.1f;
    private void Update()
    {
        if (Time.time > action)
        {
            action += period;
            Universal.ChangeWindowTitle(Strings.RandomString(StringType.Lowercase, 30));
        }
    }
}

```
