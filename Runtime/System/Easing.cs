using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace com.Klazapp.Utility
{
    /// <summary>
    /// The <c>Easing</c> class provides a collection of easing functions commonly used in animation and interpolation.
    /// These functions define the rate at which a value changes over time, creating smooth transitions.
    /// Each easing function is identified by an <see cref="EaseType"/> enum and can be selected using the 
    /// <see cref="SetEasingByEaseType"/> method. The class also supports aggressive inlining for performance optimization.
    /// </summary>
    public static class Easing
    {
        /// <summary>
        /// Sets the easing function based on the specified <paramref name="easeType"/>.
        /// </summary>
        /// <param name="easeType">The type of easing function to use.</param>
        /// <param name="t">The time parameter, typically in the range [0, 1].</param>
        /// <returns>The eased value at the given time.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SetEasingByEaseType(EaseType easeType, float t) => easeType switch
        {
            EaseType.Linear => Linear(t),
            EaseType.InQuad => InQuad(t),
            EaseType.OutQuad => OutQuad(t),
            EaseType.InOutQuad => InOutQuad(t),
            EaseType.InCubic => InCubic(t),
            EaseType.OutCubic => OutCubic(t),
            EaseType.InOutCubic => InOutCubic(t),
            EaseType.InQuart => InQuart(t),
            EaseType.OutQuart => OutQuart(t),
            EaseType.InOutQuart => InOutQuart(t),
            EaseType.InQuint => InQuint(t),
            EaseType.OutQuint => OutQuint(t),
            EaseType.InOutQuint => InOutQuint(t),
            EaseType.InSine => InSine(t),
            EaseType.OutSine => OutSine(t),
            EaseType.InOutSine => InOutSine(t),
            EaseType.InExpo => InExpo(t),
            EaseType.OutExpo => OutExpo(t),
            EaseType.InOutExpo => InOutExpo(t),
            EaseType.InCirc => InCirc(t),
            EaseType.OutCirc => OutCirc(t),
            EaseType.InOutCirc => InOutCirc(t),
            EaseType.InElastic => InElastic(t),
            EaseType.OutElastic => OutElastic(t),
            EaseType.InOutElastic => InOutElastic(t),
            EaseType.InBack => InBack(t),
            EaseType.OutBack => OutBack(t),
            EaseType.InOutBack => InOutBack(t),
            EaseType.InBounce => InBounce(t),
            EaseType.OutBounce => OutBounce(t),
            EaseType.InOutBounce => InOutBounce(t),
            _ => Linear(t),
        };

        #region Linear
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float Linear(float t) => t;
        #endregion

        #region Quadratic
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InQuad(float t) => t * t;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float OutQuad(float t) => 1 - InQuad(1 - t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InOutQuad(float t)
        {
            if (t < 0.5) return InQuad(t * 2) / 2;
            return 1 - InQuad((1 - t) * 2) / 2;
        }
        #endregion

        #region Cubic
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InCubic(float t) => t * t * t;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float OutCubic(float t) => 1 - InCubic(1 - t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InOutCubic(float t)
        {
            if (t < 0.5) return InCubic(t * 2) / 2;
            return 1 - InCubic((1 - t) * 2) / 2;
        }
        #endregion

        #region Quartic
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InQuart(float t) => t * t * t * t;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float OutQuart(float t) => 1 - InQuart(1 - t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InOutQuart(float t)
        {
            if (t < 0.5) return InQuart(t * 2) / 2;
            return 1 - InQuart((1 - t) * 2) / 2;
        }
        #endregion

        #region Quintic
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InQuint(float t) => t * t * t * t * t;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float OutQuint(float t) => 1 - InQuint(1 - t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InOutQuint(float t)
        {
            if (t < 0.5) return InQuint(t * 2) / 2;
            return 1 - InQuint((1 - t) * 2) / 2;
        }
        #endregion

        #region Sine
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InSine(float t) => (float)-math.cos(t * math.PI / 2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float OutSine(float t) => (float)math.sin(t * math.PI / 2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InOutSine(float t) => (float)(math.cos(t * math.PI) - 1) / -2;
        #endregion

        #region Exponential
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InExpo(float t) => (float)math.pow(2, 10 * (t - 1));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float OutExpo(float t) => 1 - InExpo(1 - t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InOutExpo(float t)
        {
            if (t < 0.5) return InExpo(t * 2) / 2;
            return 1 - InExpo((1 - t) * 2) / 2;
        }
        #endregion

        #region Circular
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InCirc(float t) => -((float)math.sqrt(1 - t * t) - 1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float OutCirc(float t) => 1 - InCirc(1 - t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InOutCirc(float t)
        {
            if (t < 0.5) return InCirc(t * 2) / 2;
            return 1 - InCirc((1 - t) * 2) / 2;
        }
        #endregion

        #region Elastic
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InElastic(float t) => 1 - OutElastic(1 - t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float OutElastic(float t)
        {
            const float p = 0.3f;
            return (float)math.pow(2, -10 * t) * (float)math.sin((t - p / 4) * (2 * math.PI) / p) + 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InOutElastic(float t)
        {
            if (t < 0.5) return InElastic(t * 2) / 2;
            return 1 - InElastic((1 - t) * 2) / 2;
        }
        #endregion

        #region Back
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InBack(float t)
        {
            const float s = 1.70158f;
            return t * t * ((s + 1) * t - s);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float OutBack(float t) => 1 - InBack(1 - t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InOutBack(float t)
        {
            if (t < 0.5) return InBack(t * 2) / 2;
            return 1 - InBack((1 - t) * 2) / 2;
        }
        #endregion

        #region Bounce
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InBounce(float t) => 1 - OutBounce(1 - t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float OutBounce(float t)
        {
            const float div = 2.75f;
            const float mult = 7.5625f;

            switch (t)
            {
                case < 1 / div:
                    return mult * t * t;
                case < 2 / div:
                    t -= 1.5f / div;
                    return mult * t * t + 0.75f;
                default:
                {
                    if (t < 2.5 / div)
                    {
                        t -= 2.25f / div;
                        return mult * t * t + 0.9375f;
                    }
                    else
                    {
                        t -= 2.625f / div;
                        return mult * t * t + 0.984375f;
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InOutBounce(float t)
        {
            if (t < 0.5) return InBounce(t * 2) / 2;
            return 1 - InBounce((1 - t) * 2) / 2;
        }
        #endregion
    }
}
