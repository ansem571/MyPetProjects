using MathLibrary.BasicFormulas;
using MathLibrary.Contracts.Constants;
using MathLibrary.Contracts.Matrices;
using MathLibrary.Contracts.Positions;
using System;

namespace MathLibrary.SpecialFormulas
{
    public class TransformCalculator
    {
        private readonly DistanceCalculator _distanceCalculator;

        public TransformCalculator(DistanceCalculator distanceCalculator)
        {
            _distanceCalculator = distanceCalculator ?? throw new ArgumentNullException(nameof(distanceCalculator));
        }
        /// <summary>
        /// Returns the normalized direction of 2 vectors
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public Vector3d GetDirectional(Vector3d origin, Vector3d destination)
        {
            var distance = _distanceCalculator.Distance(origin, destination);
            return new Vector3d
            {
                X = destination.X / distance,
                Y = destination.Y / distance,
                Z = destination.Z / distance
            };
        }

        public Transform TransformRight(Transform transform)
        {
            var currentRotation = transform.Rotation;
            currentRotation += TransformConstants.RightTransform;
            if(currentRotation.Y > TransformConstants.MaxDegree)
            {
                currentRotation.Y -= TransformConstants.MaxDegree;
            }
            return transform;
        }
    }
}
