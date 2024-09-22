using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MeetingRoomBooking.WebApp.Models {
    public class LoginViewModel {

        [JsonPropertyName("userCode")]
        [Required(ErrorMessage = "UserCode is required.")]
        public string UserCode { get; set; }
        /// <summary>パスワード</summary>
        [JsonPropertyName("password")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

    }
}
