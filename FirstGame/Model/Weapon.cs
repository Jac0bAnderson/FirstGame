using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace FirstGame.Model
{
	public class Weapon
	{
		private Texture2D texture;
		private  int damage;
		private float wepSpeed;
		private Vector2 position;

		public Texture2D Texture
		{
			Get {return texture;}
			Set { texture = value;}
		}
		public int Damage
		{
			get {return damage; }
			set { damage = value; }
		}
		public float wepSpeed
		{
			get {return wepSpeed;}
			set {wepSpeed = value;}
		}
		public Vector2 Position
		{
			get {return Position;}
			set { VertexPosition = value;}
		}


		public void Initialize(Texture2D Texture, Vector2 position)
		{
			this.texture = texture;
			this.position = position;
			this.damage = 30;
			this.wepSpeed = .2;
		}

		public void Update()
		{
			position.X += wepSpeed;
			position.Y = 0;
		}
		public void draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(Texture, position:, null, Color.White, VertexPosition.Y*3, Vector2.Zero, 1F, SpriteEffects.None, 0f);
		}



	}
}

